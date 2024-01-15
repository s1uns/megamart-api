using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Pagination;

namespace BLL.Services.GoodManagement.Interfaces
{
    public interface IGoodService
    {
        Task<CreateGoodDto> AddGoodAsync(CreateGoodDto goodDto);
        Task<EditGoodDto> UpdateGoodAsync(EditGoodDto newGoodDto);
        Task<List<GoodShortInfoDto>> GetAllGoodsAsync();
        Task<GoodFullInfoDto> GetGoodByIdAsync(Guid goodId);
        Task<PageResponseDto<GoodShortInfoDto>> GetGoodsAsync(Guid? categoryId, string sortBy, bool order, string search, int page, int limit);
        Task DeleteGoodAsync(Guid goodId);
        Task<GoodFullInfoDto> AddGoodToCategoryAsync(Guid goodId, Guid categoryId);
    }
}