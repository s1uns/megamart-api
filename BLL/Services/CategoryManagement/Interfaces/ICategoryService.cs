using Infrustructure.Dto.Categories;

namespace BLL.Services.CategoryManager.Interfaces
{
    public interface ICategoryService
    {
        public Task<CreateCategoryDto> AddAsync(CreateCategoryDto categoryDto);
        public Task<EditCategoryDto> UpdateAsync(EditCategoryDto newCategoryDto);
        public Task<List<CategoryShortInfoDto>> GetAllAsync();
        public Task<CategoryFullInfoDto> GetByIdAsync(Guid categoryId);
        public Task DeleteAsync(Guid categoryId);

    }
}
