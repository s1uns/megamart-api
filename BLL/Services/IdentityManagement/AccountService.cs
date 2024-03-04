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
using Infrustructure.ErrorHandling.Exceptions.Services.Account;
using Microsoft.AspNetCore.Http;
using Infrustructure.Extensions;

namespace BLL.Services.IdentityManagement
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly MegamartContext _context;
        private readonly ILogger<AccountService> _logger;
        private readonly IHttpContextAccessor _contextAccessor;


        public AccountService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenGenerator tokenGenerator, MegamartContext context, ILogger<AccountService> logger, IHttpContextAccessor contextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenGenerator = tokenGenerator;
            _context = context;
            _logger = logger;
            _contextAccessor = contextAccessor;
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

        public async Task<Result<bool, Error>> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
        {
            try
            {
                var vaildUserEmail = _contextAccessor.TryGetUserEmail(out string userEmail);
                if (vaildUserEmail is false)
                {
                    throw new InvalidUserException("wrong user");
                }

                var identityUser = await _userManager.FindByEmailAsync(userEmail);
                var isCredentialsValid = await _userManager.CheckPasswordAsync(identityUser, resetPasswordDto.OldPassword);

                if (!isCredentialsValid)
                {
                    throw new WrongOldPasswordException("wrong old password");
                }

                if (isCredentialsValid)
                {
                    var isNewPasswordValid = await _userManager.ValidateAsync(resetPasswordDto.NewPassword);

                    if (!isNewPasswordValid._isSuccess)
                    {
                        return IdentityServiceErrors.ResetPasswordError(isNewPasswordValid._error.Message);
                    }

                    await _userManager.RemovePasswordAsync(identityUser);
                    await _userManager.AddPasswordAsync(identityUser, resetPasswordDto.NewPassword);
                }

                return true;
            }
            catch (WrongOldPasswordException ex)
            {
                _logger.LogError($"BLL.ResetPasswordAsync Reset Password ERROR: {ex.Message}");
                return IdentityServiceErrors.ResetPasswordError(ex.Message);
            }
            catch (InvalidUserException ex)
            {
                _logger.LogError($"BLL.ResetPasswordAsync Invalid User ERROR: {ex.Message}");
                return IdentityServiceErrors.ResetPasswordError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.ResetPasswordAsync ERROR: {ex.Message}");
                return IdentityServiceErrors.ResetPasswordError("something went wrong");

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