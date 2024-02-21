using Infrustructure.ErrorHandling.Errors.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Errors.ServiceErrors
{
    public static class IdentityServiceErrors
    {
        public static Error CreateAccountError(string errorMessage) => new Error("Create Account Error", $"Failed to create new account: {errorMessage}");
    }
}