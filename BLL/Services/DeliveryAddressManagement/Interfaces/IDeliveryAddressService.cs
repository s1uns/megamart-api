using Core.Models;
using Infrustructure.Dto.Categories;

namespace BLL.Services.DeliveryAddressManagement.Interfaces
{
    public interface IDeliveryAddressService
    {
        public Task<CreateCategoryDto> AddAsync(CreateCategoryDto categoryDto);
        public Task<EditCategoryDto> UpdateAsync(EditCategoryDto newGoodDto);
        public Task<List<CategoryShortInfoDto>> GetAllAsync();
        public Task<CategoryFullInfoDto> GetByIdAsync(Guid categoryId);
        public Task DeleteAsync(Guid categoryId);
    }
}
