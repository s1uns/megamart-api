using BLL.Services.IdentityManagement.Interfaces;
using Core.Enums;
using Core.Result;
using Infrustructure.Dto.Account;
using Infrustructure.ErrorHandling.Errors.Base;
using megamart_api.Context;
using Microsoft.AspNetCore.Identity;
using Infrustructure.ErrorHandling.Errors.ServiceErrors;
using Microsoft.Extensions.Logging;
using Core.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Infrustructure.ErrorHandling.Exceptions.Services.Account;

namespace BLL.Services.IdentityManagement
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly MegamartContext _context;
        private readonly ILogger<AccountService> _logger;


        public AccountService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenGenerator tokenGenerator, MegamartContext context, ILogger<AccountService> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenGenerator = tokenGenerator;
            _context = context;
            _logger = logger;
        }

        public async Task<Result<IdentityUser, Error>> CreateIdentityUserAsync(CredentialsDto credentials, Roles role)
        {
            try
            {
                var identityUser = new IdentityUser
                {
                    Email = credentials.Email,
                    UserName = credentials.Email
                };

                var createIdentity = await _userManager.CreateAsync(identityUser, credentials.Password);

                if (createIdentity.Succeeded is false)
                {
                    return IdentityServiceErrors.CreateAccountError(createIdentity.Errors.Select(e => e.Description).FirstOrDefault());
                }

                await AssureRoleCreatedAsync(role.ToString());
                await _userManager.AddToRoleAsync(identityUser, role.ToString());

                return identityUser;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.CreateIdentityUserAsync ERROR: {ex.Message}");

                return IdentityServiceErrors.CreateAccountError("something went wrong.");
            }

        }

        public async Task<Result<SignInResultDto, Error>> CreateCustomerAsync(CredentialsDto credentials)
        {
            try
            {
                var createIdentityResponse = await CreateIdentityUserAsync(credentials, Roles.Customer);

                if (createIdentityResponse._isSuccess is false)
                {
                    return IdentityServiceErrors.CreateCustomerError(createIdentityResponse._error.Message);
                }

                var customer = new Customer
                {
                    Id = Guid.Parse(createIdentityResponse._value.Id),
                    Email = credentials.Email,
                    CreatedAt = DateTime.UtcNow
                };

                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();

                var token = await _tokenGenerator.GenerateAsync(createIdentityResponse._value);

                return new SignInResultDto
                {
                    UserId = customer.Id,
                    Bearer = token
                };

            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.CreateCustomerAsync ERROR: {ex.Message}");

                return IdentityServiceErrors.CreateCustomerError("something went wrong.");

            }
        }

        public async Task<Result<SignInResultDto, Error>> CreateSellerAsync(CredentialsDto credentials)
        {
            try
            {
                var createIdentityResponse = await CreateIdentityUserAsync(credentials, Roles.Seller);

                if (createIdentityResponse._isSuccess is false)
                {
                    return IdentityServiceErrors.CreateSellerError(createIdentityResponse._error.Message);
                }

                var seller = new Seller
                {
                    Id = Guid.Parse(createIdentityResponse._value.Id),
                    Email = credentials.Email,
                    CreatedAt = DateTime.UtcNow,
                    IsVerified = false
                };

                await _context.Sellers.AddAsync(seller);
                await _context.SaveChangesAsync();

                var token = await _tokenGenerator.GenerateAsync(createIdentityResponse._value);

                return new SignInResultDto
                {
                    UserId = seller.Id,
                    Bearer = token
                };

            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.CreateSellerAsync ERROR: {ex.Message}");

                return IdentityServiceErrors.CreateCustomerError("something went wrong.");

            }
        }

        public async Task<Result<SignInResultDto, Error>> SignInAsync(CredentialsDto credentials)
        {
            try
            {
                var identityUser = await _userManager.FindByEmailAsync(credentials.Email);

                if (identityUser is null)
                {
                    throw new SignInExceiption("Wrong email");
                }

                var isCredentialsValid = await _userManager.CheckPasswordAsync(identityUser, credentials.Password);

                if (!isCredentialsValid)
                {
                    throw new SignInExceiption("Wrong password");
                }

                var token = await _tokenGenerator.GenerateAsync(identityUser);
                var result = new SignInResultDto()
                {
                    UserId = Guid.Parse(identityUser.Id),
                    Bearer = token,
                };
                return result;
            }
            catch (SignInExceiption ex)
            {
                _logger.LogError($"BLL.SignInAsync ERROR: {ex.Message}");

                return IdentityServiceErrors.SignInError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.SignInAsync ERROR: {ex.Message}");

                return IdentityServiceErrors.SignInError("something went wrong.");
            }
        }

        private async Task AssureRoleCreatedAsync(string role)
        {
            if (await _roleManager.RoleExistsAsync(role))
            {
                return;
            }

            await _roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}