﻿using Infrustructure.ErrorHandling.Errors.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Errors.ServiceErrors
{
    public static class IdentityServiceErrors
    {
        public static readonly Error InvalidUserEmail = new Error("Invalid User Email Error", "User's email is invalid");
        public static readonly Error WrongOldPasswordError = new Error("Wrong Old Password Error", "The old password is wrong");
        public static Error CreateAccountError(string errorMessage) => new Error("Create Account Error", errorMessage);
        public static Error CreateCustomerError(string errorMessage) => new Error("Create Customer Error", $"Failed to create new customer: {errorMessage}");
        public static Error CreateSellerError(string errorMessage) => new Error("Create Seller Error", $"Failed to create new seller: {errorMessage}");
        public static Error SignInError(string errorMessage) => new Error("Sign In Error", $"Failed to sign in: {errorMessage}");
        public static Error ResetPasswordError(string errorMessage) => new Error("Reset Password Error", $"Failed to reset your password: {errorMessage}");
        public static Error InvalidNewPasswordError(string errorMessage) => new Error("Invalid New Password Error", errorMessage);
    }
}