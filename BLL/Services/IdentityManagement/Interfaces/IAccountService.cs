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
    public interface IAccountService
    {
        public Task<Result<IdentityUser, Error>> CreateIdentityUserAsync(CredentialsDto credentials, Roles role);
        public Task<Result<SignInResultDto, Error>> CreateSellerAsync(CredentialsDto credentials);
        public Task<Result<SignInResultDto, Error>> CreateCustomerAsync(CredentialsDto credentials);
        public Task<Result<SignInResultDto, Error>> SignInAsync(CredentialsDto credentials);


    }
}
