using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;

namespace BLL.Services.GoodManagement.Interfaces
{
    public interface IGoodService
    {
        Task<CreateGoodDto> AddGoodAsync(CreateGoodDto goodDto);
        Task<EditGoodDto> UpdateGoodAsync(EditGoodDto newGoodDto);
        Task<List<GoodShortInfoDto>> GetAllGoodsAsync();
        Task<GoodFullInfoDto> GetGoodByIdAsync(Guid goodId);
        Task<List<GoodShortInfoDto>> GetGoodsByCategoryAsync(Guid? categoryId);
        Task DeleteGoodAsync(Guid goodId);
        Task<GoodFullInfoDto> AddGoodToCategoryAsync(Guid goodId, Guid categoryId);
    }
}