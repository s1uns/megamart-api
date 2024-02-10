using AutoMapper;
using BLL.Services.CategoryManager.Interfaces;
using Core.Models;
using Core.Result;
using DAL.Repository.Interface;
using Infrustructure.Dto.Categories;
using Infrustructure.ErrorHandling.Errors.Base;
using Infrustructure.ErrorHandling.Errors.ServiceErrors;
using Infrustructure.ErrorHandling.Services.GenericException;
using Microsoft.Extensions.Logging;

namespace BLL.Services.CategoryManager
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly ILogger<CategoryService> _logger;
        private readonly IMapper _mapper;
        public CategoryService(IRepository<Category> repository, ILogger<CategoryService> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Result<CreateCategoryDto, Error>> AddAsync(CreateCategoryDto categoryDto)
        {
            try
            {
                var category = _mapper.Map<Category>(categoryDto);
                await _repository.AddAsync(category);
                return categoryDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddAsync Category ERROR: {ex.Message}");
                return CategoryServiceErrors.AddCategoryError;
            }
        }

        public async Task<Result<bool, Error>> DeleteAsync(Guid categoryId)
        {
            try
            {
                await _repository.DeleteAsync(categoryId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteAsync Category ERROR: {ex.Message}");
                return CategoryServiceErrors.DeleteCategoryError;
            }
        }

        public async Task<Result<List<CategoryShortInfoDto>, Error>> GetAllAsync()
        {
            try
            {
                var categories = _mapper.Map<List<CategoryShortInfoDto>>(await _repository.GetAllAsync());
                return categories;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetAllAsync Category ERROR: {ex.Message}");
                return CategoryServiceErrors.GetCategoriesError;
            }
        }

        public async Task<Result<CategoryFullInfoDto, Error>> GetByIdAsync(Guid categoryId)
        {
            try
            {
                var category = _mapper.Map<CategoryFullInfoDto>(await _repository.GetByIdAsync(categoryId));
                return category;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetByIdAsync Category ERROR: {ex.Message}");
                return CategoryServiceErrors.GetCategoryError;
            }
        }

        public async Task<Result<EditCategoryDto, Error>> UpdateAsync(EditCategoryDto newCategoryDto)
        {
            try
            {
                var newCategory = await _repository.GetByIdAsync(newCategoryDto.Id);
                _mapper.Map<Category>(newCategoryDto);
                await _repository.UpdateAsync(newCategory);
                return newCategoryDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateAsync Category ERROR: {ex.Message}");
                throw new ServiceUpdateException(ex.Message);
            }
        }
    }
}