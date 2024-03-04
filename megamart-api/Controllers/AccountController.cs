using BLL.Services.IdentityManagement.Interfaces;
using Infrustructure.Dto.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;

        }

        /// <summary>
        /// Creates a new customer account.
        /// </summary>
        /// <param name="request">The request to create a customer account.</param>
        /// <remarks>
        /// If the operation is successful, it will return a SignUpResultDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPost("customer/register")]
        public async Task<IActionResult> SignUpCustomer([FromBody] CredentialsDto request)
        {
            var result = await _accountService.CreateCustomerAsync(request);
            return this.CreateResponse(result);
        }

        /// <summary>
        /// Creates a new seller account.
        /// </summary>
        /// <param name="request">The request to create a seller account.</param>
        /// <remarks>
        /// If the operation is successful, it will return a SignUpResultDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPost("seller/register")]
        public async Task<IActionResult> SignUpSeller([FromBody] CredentialsDto request)
        {
            var result = await _accountService.CreateSellerAsync(request);
            return this.CreateResponse(result);
        }

        /// <summary>
        /// Performs user login.
        /// </summary>
        /// <param name="request">The request to perform user login</param>        
        /// If the operation is successful, it will return a SignInResultDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] CredentialsDto request)
        {
            var result = await _accountService.SignInAsync(request);
            return this.CreateResponse(result);
        }

        /// <summary>
        /// Resets user's password.
        /// </summary>
        /// <param name="request">The request to reset user's password</param>        
        /// If the operation is successful, it will return a SignInResultDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto request)
        {
            var result = await _accountService.ResetPasswordAsync(request);
            return this.CreateResponse(result);
        }
    }
}
