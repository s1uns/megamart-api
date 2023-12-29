/*using BLL.Services.DeliveryMethodManagement.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/delivery_methods")]
    [ApiController]
    public class DeliveryMethodController : ControllerBase
    {
        private readonly IDeliveryMethodService _deliveryMethodService;
        private readonly ILogger<DeliveryMethodController> _logger;

        public DeliveryMethodController(IDeliveryMethodService deliveryMethodService, ILogger<DeliveryMethodController> logger)
        {
            _deliveryMethodService = deliveryMethodService;
            _logger = logger;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAllMethods()
        {
            try
            {
                var allMethods = await _deliveryMethodService.GetAllAsync();

                return Ok(allMethods);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryMethod.GetAllMethods ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddDeliveryMethod([FromBody]DeliveryMethod deliveryMethod)
        {
            try
            {
                await _deliveryMethodService.AddAsync(deliveryMethod);

                return Ok(deliveryMethod);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryMethod.AddDeliveryMethod ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeliveryMethod(Guid id)
        {
            try
            {
                var deliveryMethod = await _deliveryMethodService.GetByIdAsync(id);

                return Ok(deliveryMethod);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryMethod.GetDeliveryMethod ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateDeliveryMethod([FromBody]DeliveryMethod deliveryMethod)
        {
            try
            {
                await _deliveryMethodService.UpdateAsync(deliveryMethod);

                return Ok(deliveryMethod);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryMethod.UpdateDeliveryMethod ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliveryMethod(Guid id)
        {
            try
            {
                await _deliveryMethodService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.DeliveryMethod.DeleteDeliveryMethod ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}
*/