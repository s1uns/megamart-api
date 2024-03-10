using AutoMapper;
using BLL.Services.ProfileManagement;
using BLL.Services.RatingManagement.Interface;
using Core.Models;
using Core.Result;
using Infrustructure.Dto.Rating;
using Infrustructure.ErrorHandling.Errors.Base;
using Infrustructure.ErrorHandling.Errors.ServiceErrors;
using Infrustructure.Extensions;
using megamart_api.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.RatingManagement
{
    public class RatingService : IRatingService
    {
        private readonly ILogger<RatingService> _logger;
        private readonly MegamartContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public RatingService(ILogger<RatingService> logger, MegamartContext context, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<Result<bool, Error>> ClearGoodsRatingAsync(Guid goodId)
        {
            try
            {

                var isIdValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (isIdValid is false)
                {
                    return UserErrors.InvalidUserId;
                }

                var rating = await _context.Ratings.FirstOrDefaultAsync(r => r.CustomerId == userId && r.GoodId == goodId);

                if(rating is null)
                {
                    return RatingServiceErrors.RatingNotFoundError;
                }

                _context.Ratings.Remove(rating);
                 await UpdateGoodsRating(goodId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.ClearGoodsRatingAsync ERROR: {ex.Message}");

                return RatingServiceErrors.ClearGoodsRatingError;
            }
        }

        public async Task<Result<SellersRatingDto, Error>> GetSellersRatingAsync(Guid sellerId)
        {
            try
            {
                var seller = await _context
                    .Sellers
                    .Include(s => s.Goods)
                    .ThenInclude(g => g.Ratings)
                    .FirstOrDefaultAsync(g => g.Id == sellerId);

                if (seller is null)
                {
                    return UserErrors.InvalidUserId;
                }

                var rating = await CalculateSellersRatingAsync(seller.Goods);

                return new SellersRatingDto(rating);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetSellersRatingAsync ERROR: {ex.Message}");

                return RatingServiceErrors.GetSellersRatingError;
            }
        }

        public async Task<Result<GoodsRatingDto, Error>> SetGoodsRatingAsync(SetGoodsRatingDto setGoodsRatingDto)
        {
            try
            {
                var isIdValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (isIdValid is false)
                {
                    return UserErrors.InvalidUserId;
                }

                if(setGoodsRatingDto.Value > 5f)
                {
                    return RatingServiceErrors.SetGoodsRatingError;
                }

                await RateGoodAsync(userId, setGoodsRatingDto.GoodId, setGoodsRatingDto.Value);

                var rating = await UpdateGoodsRating(setGoodsRatingDto.GoodId);

                return new GoodsRatingDto(rating._value, true);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.SetGoodsRatingAsync ERROR: {ex.Message}");

                return RatingServiceErrors.SetGoodsRatingError;
            }

        }

        private async Task<float> CalculateGoodsRatingAsync(ICollection<Rating> ratings)
        {
            var ratingSum = 0f;
            var count = (float)ratings.Count;
            foreach (var r in ratings)
            {
                ratingSum += r.Value;
            }

            return count > 0 ? ratingSum / count : 0f;
        }

        private async Task<float> CalculateSellersRatingAsync(ICollection<Good> goods)
        {
            var ratingSum = 0f;
            var counter = 0f;
            foreach (var g in goods)
            {
                ratingSum += await CalculateGoodsRatingAsync(g.Ratings);

                if(g.Ratings.Count > 0)
                {
                    counter++;
                }
            }

            return counter > 0 ? ratingSum / counter : 0f;
        }

        private bool IsGoodRatedByUser(Guid goodId, Guid userId, out float usersRating)
        {
            var predicate = new Func<Rating, bool>(r => r.GoodId == goodId && r.CustomerId == userId);
            usersRating = 0f;
            var isRated = _context.Ratings.Any(predicate);

            if (!isRated)
            {
                return false;
            }

            usersRating = _context.Ratings.FirstOrDefault(predicate).Value;
            return true;
        }

        private async Task RateGoodAsync(Guid userId, Guid goodId, float value)
        {
            var rating = await _context.Ratings.FirstOrDefaultAsync(r => r.CustomerId == userId && r.GoodId == goodId);

            if (rating is null)
            {
                await _context.Ratings.AddAsync(new Rating
                {
                    CustomerId = userId,
                    GoodId = goodId,
                    Value = value
                });

                await _context.SaveChangesAsync();
                return;
            }

            rating.Value = value;
            await _context.SaveChangesAsync();
        }

        private async Task<Result<float, Error>> UpdateGoodsRating(Guid goodId)
        {
            var good = await _context
                    .Goods
                    .Include(g => g.Ratings)
                    .FirstOrDefaultAsync(g => g.Id == goodId);

            if (good is null)
            {
                return GoodServiceErrors.GetGoodError;
            }
            var rating = await CalculateGoodsRatingAsync(good.Ratings);
            good.Rating = rating;
            await _context.SaveChangesAsync();

            return rating;
        }


    }
}
