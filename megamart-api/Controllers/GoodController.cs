using BLL.Services.GoodManagement.Interfaces;
using Core.Enums;
using Core.Models;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Goods;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/goods")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        private readonly IGoodService _goodService;

        public GoodController(IGoodService goodService)
        {
            _goodService = goodService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllGoodsByCategory([FromQuery] string? search, [FromQuery] Guid? category, [FromQuery] string sortBy = "rating", [FromQuery] bool sortOrder = true, [FromQuery] int page = 1, [FromQuery] int limit = 5)
        {
            var result = await _goodService.GetGoodsAsync(category, sortBy, sortOrder, search, page, limit);

            return this.CreateResponse(result);
        }

        [HttpPost("create")]
        [Authorize(Roles = nameof(Roles.Seller))]
        public async Task<IActionResult> AddGood([FromBody] CreateGoodDto goodDto)
        {

            var result = await _goodService.AddGoodAsync(goodDto);

            return this.CreateResponse(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGood(Guid id)
        {
            var result = await _goodService.GetGoodByIdAsync(id);

            return this.CreateResponse(result);
        }

        [HttpPost("update")]
        [Authorize(Roles = nameof(Roles.Seller))]
        public async Task<IActionResult> UpdateGood([FromBody] EditGoodDto good)
        {

            var result = await _goodService.UpdateGoodAsync(good);

            return this.CreateResponse(result);

        }

        [HttpDelete("{id}")]
        [Authorize(Roles = nameof(Roles.Seller))]
        public async Task<IActionResult> DeleteGood(Guid id)
        {

            var result = await _goodService.DeleteGoodAsync(id);

            return this.CreateResponse(result);
        }
    }
}
