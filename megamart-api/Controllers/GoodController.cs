using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/goods")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        private readonly IGoodService _goodService;
        private readonly ILogger<GoodController> _logger;

        public GoodController(IGoodService goodService, ILogger<GoodController> logger)
        {
            _goodService = goodService;
            _logger = logger;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAllGoods()
        {
            try
            {
                var allGoods = await _goodService.GetAllAsync();

                return Ok(allGoods);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.GetAllGoods ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddGood([FromBody]Good good)
        {
            try
            {
                await _goodService.AddAsync(good);

                return Ok(good);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.AddGood ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGood(Guid id)
        {
            try
            {
                var good = await _goodService.GetByIdAsync(id);

                return Ok(good);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.GetGood ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateGood([FromBody]Good good)
        {
            try
            {
                await _goodService.UpdateAsync(good);

                return Ok(good);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.UpdateGood ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGood(Guid id)
        {
            try
            {
                await _goodService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.DeleteGood ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}
