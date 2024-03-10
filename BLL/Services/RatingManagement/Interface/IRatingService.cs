using Core.Result;
using Infrustructure.Dto.Rating;
using Infrustructure.ErrorHandling.Errors.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.RatingManagement.Interface
{
    public interface IRatingService
    {
        public Task<Result<SellersRatingDto, Error>> GetSellersRatingAsync(Guid sellerId);
        public Task<Result<GoodsRatingDto, Error>> SetGoodsRatingAsync(SetGoodsRatingDto setGoodsRatingDto);
        public Task<Result<bool, Error>> ClearGoodsRatingAsync(Guid goodId);
    }
}
