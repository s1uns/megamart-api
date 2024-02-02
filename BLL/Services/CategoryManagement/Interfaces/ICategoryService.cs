using Core.Result;
using Infrustructure.Dto.Categories;
using Infrustructure.ErrorHandling.Errors.Base;

namespace BLL.Services.CategoryManager.Interfaces
{
    public interface ICategoryService
    {
        public Task<Result<CreateCategoryDto, Error>> AddAsync(CreateCategoryDto categoryDto);
        public Task<Result<EditCategoryDto,Error>> UpdateAsync(EditCategoryDto newCategoryDto);
        public Task<Result<List<CategoryShortInfoDto>, Error>> GetAllAsync();
        public Task<Result<CategoryFullInfoDto,Error>> GetByIdAsync(Guid categoryId);
        public Task<Result<bool, Error>> DeleteAsync(Guid categoryId);

    }
}
