using BLL.Services.RatingManagement.Interface;
using Core.Enums;
using Infrustructure.Dto.Rating;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        /// <summary>
        /// Gets a rating of specific seller.
        /// </summary>
        /// <param name="id">The id of a specific seller.</param>
        /// <remarks>
        /// If the operation is successful, it will return a SellersRatingDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpGet]
        [Route("seller/{id}")]
        public async Task<IActionResult> GetSellersRating(Guid id)
        {
            var result = await _ratingService.GetSellersRatingAsync(id);

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Sets a rating for specific good.
        /// </summary>
        /// <param name="setGoodsRatingDto">The dto with info about the rating.</param>
        /// <remarks>
        /// If the operation is successful, it will return a GoodsRatingDto.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPost]
        [Route("good/set-rating")]
        [Authorize(Roles = nameof(Roles.Customer))]
        public async Task<IActionResult> SetGoodsRating([FromBody]SetGoodsRatingDto setGoodsRatingDto)
        {
            var result = await _ratingService.SetGoodsRatingAsync(setGoodsRatingDto);

            return this.CreateResponse(result);
        }

        /// <summary>
        /// Clears the user's rating for specific good.
        /// </summary>
        /// <param name="id">The id of the good.</param>
        /// <remarks>
        /// If the operation is successful, it will return a boolean.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpPost]
        [Route("good/{id}")]
        [Authorize(Roles = nameof(Roles.Customer))]
        public async Task<IActionResult> ClearGoodsRating(Guid id)
        {
            var result = await _ratingService.ClearGoodsRatingAsync(id);

            return this.CreateResponse(result);
        }
    }
}
