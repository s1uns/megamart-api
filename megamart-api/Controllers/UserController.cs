/*using BLL.Services.CategoryManager;
using BLL.Services.CategoryManager.Interfaces;
using BLL.Services.CutomerManagement.Interfaces;
using BLL.Services.SellerManagement.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/profiles")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ISellerService _sellerService;
        private readonly ILogger<UserController> _logger;

        public UserController(ICustomerService customerService, ISellerService sellerService, ILogger<UserController> logger)
        {
            _customerService = customerService;
            _sellerService = sellerService;
            _logger = logger;
        }

        [HttpGet("sellers")]
        public async Task<IActionResult> GetAllSellers()
        {
            try
            {
                var allSellers = await _sellerService.GetAllAsync();

                return Ok(allSellers);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.GetAllSellers ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                var allCustomers = await _customerService.GetAllAsync();

                return Ok(allCustomers);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.GetAllCustomers ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("sellers/{id}")]
        public async Task<IActionResult> GetSeller(Guid id)
        {
            try
            {
                var seller = await _sellerService.GetByIdAsync(id);

                return Ok(seller);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.GetSeller ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("customers/{id}")]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            try
            {
                var customer = await _customerService.GetByIdAsync(id);

                return Ok(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.GetCustomer ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("sellers/edit")]
        public async Task<IActionResult> EditSeller([FromBody]Seller newSeller)
        {
            try
            {
                await _sellerService.UpdateAsync(newSeller);

                return Ok(newSeller);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.EditSeller ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("customers/edit")]
        public async Task<IActionResult> EditCustomer([FromBody]Customer newCustomer)
        {
            try
            {
                await _customerService.UpdateAsync(newCustomer);

                return Ok(newCustomer);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.EditCustomer ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("customers/{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            try
            {
                await _customerService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.DeleteCustomer ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("seller/{id}")]
        public async Task<IActionResult> DeleteSeller(Guid id)
        {
            try
            {
                await _sellerService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Users.DeleteSeller ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}
*/