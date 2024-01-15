using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Goods;
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

 /*       [HttpGet("list")]
        public async Task<IActionResult> GetAllGoods()
        {
            try
            {
                var allGoods = await _goodService.GetAllGoodsAsync();

                return Ok(allGoods);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.GetAllGoods ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }*/

        [HttpGet("list")]
        public async Task<IActionResult> GetAllGoodsByCategory([FromQuery]Guid? category, [FromQuery] string sortBy, [FromQuery] bool order, [FromQuery] string? search, [FromQuery] int page = 1, [FromQuery] int limit = 5)
        {
            try
            {
                var allGoods = await _goodService.GetGoodsAsync(category, sortBy, order, search, page, limit);

                return Ok(allGoods);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.GetAllGoods ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddGood([FromBody] CreateGoodDto goodDto)
        {
            try
            {
                var result = await _goodService.AddGoodAsync(goodDto);

                return Ok(result);
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
                var good = await _goodService.GetGoodByIdAsync(id);

                return Ok(good);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Good.GetGood ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateGood([FromBody] EditGoodDto good)
        {
            try
            {
                await _goodService.UpdateGoodAsync(good);

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
                await _goodService.DeleteGoodAsync(id);

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
