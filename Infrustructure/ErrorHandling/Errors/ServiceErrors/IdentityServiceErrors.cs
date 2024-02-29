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
        public static Error CreateCustomerError(string errorMessage) => new Error("Create Customer Error", $"Failed to create new customer: {errorMessage}");
        public static Error CreateSellerError(string errorMessage) => new Error("Create Seller Error", $"Failed to create new seller: {errorMessage}");
        public static Error SignInError(string errorMessage) => new Error("Sign In Error", $"Failed to sign in: {errorMessage}");
    }
}