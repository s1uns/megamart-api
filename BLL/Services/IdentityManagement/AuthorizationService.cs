using BLL.Services.IdentityManagement.Interfaces;
using Core.Enums;
using Core.Result;
using Infrustructure.Dto.Account;
using Infrustructure.ErrorHandling.Errors.Base;
using megamart_api.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrustructure.ErrorHandling.Errors.ServiceErrors;
using Microsoft.AspNetCore.Mvc;


namespace BLL.Services.IdentityManagement
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly MegamartContext _context;

        public AuthorizationService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenGenerator tokenGenerator, MegamartContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenGenerator = tokenGenerator;
            _context = context;
        }

        public async Task<Result<IdentityUser, Error>> CreateIdentityUser(CredentialsDto credentials, Roles role)
        {
            var identityUser = new IdentityUser
            {
                Email = credentials.Email,
                UserName = credentials.Email
            };

            var createIdentity = await _userManager.CreateAsync(identityUser, credentials.Password);

            if(createIdentity.Succeeded is false)
            {
                return IdentityServiceErrors.CreateAccountError(createIdentity.Errors.Select(e => e.Description).FirstOrDefault());
            }

            await AssureRoleCreatedAsync(role.ToString());
            await _userManager.AddToRoleAsync(identityUser, role.ToString());

            return identityUser;

        }

        public Task<Result<IdentityUser, Error>> CreateCustomer(CredentialsDto credentials)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IdentityUser, Error>> CreateSeller(CredentialsDto credentials)
        {
            throw new NotImplementedException();
        }

        public Task<Result<SignInResultDto, Error>> SignIn(CredentialsDto credentials)
        {
            throw new NotImplementedException();
        }

        private async Task AssureRoleCreatedAsync(string role)
        {
            if(await _roleManager.RoleExistsAsync(role))
            {
                return;
            }

            await _roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}