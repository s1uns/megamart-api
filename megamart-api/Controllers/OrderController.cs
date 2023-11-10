using BLL.Services.OrderManagement.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                var allOrders = await _orderService.GetAllAsync();

                return Ok(allOrders);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Order.GetAllOrders ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddOrder([FromBody]Order order)
        {
            try
            {
                await _orderService.AddAsync(order);

                return Ok(order);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Order.AddOrder ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(Guid id)
        {
            try
            {
                var order = await _orderService.GetByIdAsync(id);

                return Ok(order);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Order.GetOrder ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateOrder([FromBody]Order order)
        {
            try
            {
                await _orderService.UpdateAsync(order);

                return Ok(order);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Order.UpdateOrder ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            try
            {
                await _orderService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Order.DeleteOrder ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}
