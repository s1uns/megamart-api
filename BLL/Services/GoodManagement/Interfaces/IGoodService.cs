using Core.Result;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Pagination;
using Infrustructure.ErrorHandling.Errors.Base;

namespace BLL.Services.GoodManagement.Interfaces
{
    public interface IGoodService
    {
        Task<Result<CreateGoodDto, Error>> AddGoodAsync(CreateGoodDto goodDto);
        Task<Result<EditGoodDto, Error>> UpdateGoodAsync(EditGoodDto newGoodDto);
        Task<Result<GoodFullInfoDto, Error>> GetGoodByIdAsync(Guid goodId);
        Task<Result<PageResponseDto<GoodShortInfoDto>, Error>> GetGoodsAsync(Guid? categoryId, string sortBy, bool order, string search, int page, int limit);
        Task<Result<bool, Error>> DeleteGoodAsync(Guid goodId);
    }
}