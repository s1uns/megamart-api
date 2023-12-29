using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;

namespace BLL.Services.GoodManagement.Interfaces
{
    public interface IGoodService
    {
        Task<CreateGoodDto> AddGoodAsync(CreateGoodDto goodDto);
        Task<EditGoodDto> UpdateGoodAsync(EditGoodDto newGoodDto);
        Task<List<GoodFullInfoDto>> GetAllGoodsAsync();
        Task<GoodFullInfoDto> GetGoodByIdAsync(Guid categoryId);
        Task DeleteGoodAsync(Guid categoryId);
    }
}