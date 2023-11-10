using BLL.Services.DeliveryAddressManagement.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/delivery_adresses")]
    [ApiController]
    public class DeliveryAddressController : ControllerBase
    {
        private readonly IDeliveryAddressService _deliveryAddressService;
        private readonly ILogger<DeliveryAddressController> _logger;

        public DeliveryAddressController(IDeliveryAddressService deliveryAddressService, ILogger<DeliveryAddressController> logger)
        {
            _deliveryAddressService = deliveryAddressService;
            _logger = logger;
        }

        //TODO add user Id to get his last address


        [HttpGet("list")]
        public async Task<IActionResult> GetAllAddresses()
        {
            try
            {
                var allAddresses = await _deliveryAddressService.GetAllAsync();

                return Ok(allAddresses);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryAddress.GetAllAddresses ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddDeliveryAddress([FromBody]DeliveryAddress deliveryAddress)
        {
            try
            {
                await _deliveryAddressService.AddAsync(deliveryAddress);

                return Ok(deliveryAddress);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryAddress.AddDeliveryAddress ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeliveryAddress(Guid id)
        {
            try
            {
                var deliveryAddress = await _deliveryAddressService.GetByIdAsync(id);

                return Ok(deliveryAddress);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryAddress.GetDeliveryAddress ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDeliveryAddress([FromBody]DeliveryAddress deliveryAddress)
        {
            try
            {
                await _deliveryAddressService.UpdateAsync(deliveryAddress);

                return Ok(deliveryAddress);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryAddress.UpdateDeliveryAddress ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliveryAddress(Guid id)
        {
            try
            {
                await _deliveryAddressService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryAddress.DeleteDeliveryAddress ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}
