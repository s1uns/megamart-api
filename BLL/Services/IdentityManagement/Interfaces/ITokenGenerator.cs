using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IdentityManagement.Interfaces
{
    public interface ITokenGenerator
    {
        public Task<string> GenerateAsync(IdentityUser user);
    }
}
