using BLL.Services.GenericService.Interfaces;
using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;

namespace BLL.Services.CategoryManager.Interfaces
{
    public interface ICategoryService
    {
        public Task<CreateCategoryDto> AddAsync(CreateCategoryDto categoryDto);
        public Task<EditCategoryDto> UpdateAsync(EditCategoryDto newGoodDto);
        public Task<List<CategoryShortInfoDto>> GetAllAsync();
        public Task<CategoryFullInfoDto> GetByIdAsync(Guid categoryId);
        public Task DeleteAsync(Guid categoryId);

    }
}
