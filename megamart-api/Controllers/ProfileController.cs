using BLL.Services.ProfileManagement;
using BLL.Services.ProfileManagement.Interface;
using Core.Enums;
using Infrustructure.Dto.UserProfile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        /// <summary>
        /// Gets a profile of specific customer.
        /// </summary>
        /// <param name="id">The id of a specific customer profile.</param>
        /// <remarks>
        /// If the operation is successful, it will return a CustomerProfileDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpGet("customers/{id}")]
        public async Task<IActionResult> GetCustomerProfile(Guid id)
        {
            var result = await _profileService.GetCustomerProfileAsync(id);

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Gets a profile of specific seller.
        /// </summary>
        /// <param name="id">The id of a specific seller profile.</param>
        /// <remarks>
        /// If the operation is successful, it will return a SellerProfileDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpGet("sellers/{id}")]
        public async Task<IActionResult> GetSellerProfile(Guid id)
        {
            var result = await _profileService.GetSellerProfileAsync(id);

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Gets customer's own profile.
        /// </summary>
        /// <remarks>
        /// If the operation is successful, it will return a CustomerProfileDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpGet("customers/me")]
        [Authorize(Roles = nameof(Roles.Customer))]
        public async Task<IActionResult> GetOwnCustomerProfile()
        {
            var result = await _profileService.GetOwnCustomerProfileAsync();

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Gets seller's own profile.
        /// </summary>
        /// <remarks>
        /// If the operation is successful, it will return a SellerProfileDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpGet("sellers/me")]
        [Authorize(Roles = nameof(Roles.Seller))]
        public async Task<IActionResult> GetOwnSellerProfile()
        {
            var result = await _profileService.GetOwnSellerProfileAsync();

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Updates customer's own profile.
        /// </summary>
        /// <param name="customerProfileDto">The dto to update customer's profile.</param>
        /// <remarks>
        /// If the operation is successful, it will return a CustomerProfileDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPut("customers/edit")]
        [Authorize(Roles = nameof(Roles.Customer))]
        public async Task<IActionResult> EditCustomerProfile([FromBody] UpdateCustomerProfileDto customerProfileDto)
        {
            var result = await _profileService.UpdateCustomerProfileAsync(customerProfileDto);

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Updates seller's own profile.
        /// </summary>
        /// <param name="sellerProfileDto">The dto to update seller's profile.</param>
        /// <remarks>
        /// If the operation is successful, it will return a SellerProfileDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPut("sellers/edit")]
        [Authorize(Roles = nameof(Roles.Seller))]
        public async Task<IActionResult> EditSellerProfile([FromBody]UpdateSellerProfileDto sellerProfileDto)
        {
            var result = await _profileService.UpdateSellerProfileAsync(sellerProfileDto);

            return this.CreateResponse(result);
        }

    }
}
