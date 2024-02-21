using Core.Enums;
using Core.Result;
using Infrustructure.Dto.Account;
using Infrustructure.ErrorHandling.Errors.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IdentityManagement.Interfaces
{
    public interface IAuthorizationService
    {
        public Task<Result<IdentityUser, Error>> CreateIdentityUser(CredentialsDto credentials, Roles role);
        public Task<Result<IdentityUser, Error>> CreateSeller(CredentialsDto credentials);
        public Task<Result<IdentityUser, Error>> CreateCustomer(CredentialsDto credentials);
        public Task<Result<SignInResultDto, Error>> SignIn(CredentialsDto credentials);


    }
}
