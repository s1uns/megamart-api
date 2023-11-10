using BLL.Services.OrderPositionManagement.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/order_positions")]
    [ApiController]
    public class OrderPositionController : ControllerBase
    {
        private readonly IOrderPositionService _orderPositionService;
        private readonly ILogger<OrderPositionController> _logger;

        public OrderPositionController(IOrderPositionService orderPositionService, ILogger<OrderPositionController> logger)
        {
            _orderPositionService = orderPositionService;
            _logger = logger;
        }

        //TODO add order Id to get it's positions
        [HttpGet("list")]
        public async Task<IActionResult> GetAllOrderPositions()
        {
            try
            {
                var allOrderPositions = await _orderPositionService.GetAllAsync();

                return Ok(allOrderPositions);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.OrderPosition.GetAllOrderPositions ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddOrderPosition([FromBody] OrderPosition orderPosition)
        {
            try
            {
                await _orderPositionService.AddAsync(orderPosition);

                return Ok(orderPosition);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.OrderPosition.AddOrderPosition ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderPosition(Guid id)
        {
            try
            {
                var orderPosition = await _orderPositionService.GetByIdAsync(id);

                return Ok(orderPosition);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.OrderPosition.GetOrderPosition ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateOrderPosition([FromBody] OrderPosition orderPosition)
        {
            try
            {
                await _orderPositionService.UpdateAsync(orderPosition);

                return Ok(orderPosition);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.OrderPosition.UpdateOrderPosition ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderPosition(Guid id)
        {
            try
            {
                await _orderPositionService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.OrderPosition.DeleteOrderPosition ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}
