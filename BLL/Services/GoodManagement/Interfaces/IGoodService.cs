using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;

namespace BLL.Services.GoodManagement.Interfaces
{
    public interface IGoodService
    {
        Task<CreateGoodDto> AddAsync(CreateGoodDto goodDto);
        Task<EditGoodDto> UpdateAsync(EditGoodDto newGoodDto);
        Task<List<GoodShortInfoDto>> GetAllAsync();
        Task<GoodFullInfoDto> GetByIdAsync(Guid categoryId);
        Task DeleteAsync(Guid categoryId);
    }
}