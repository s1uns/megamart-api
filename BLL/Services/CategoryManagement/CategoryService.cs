using AutoMapper;
using BLL.Services.CategoryManager.Interfaces;
using BLL.Services.GenericService;
using BLL.Services.GoodManagement;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.Dto.Categories;
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

        public async Task<CreateCategoryDto> AddAsync(CreateCategoryDto categoryDto)
        {
            try
            {
                var category = _mapper.Map<Category>(categoryDto);
                await _repository.AddAsync(category);
                return categoryDto;
            }
            catch (Exception ex){
                _logger.LogError($"BLL.AddAsync Category ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task DeleteAsync(Guid categoryId)
        {
            try
            {
                await _repository.DeleteAsync(categoryId);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteAsync Category ERROR: {ex.Message}");
                throw new ServiceDeleteException(ex.Message);
            }
        }

        public async Task<List<CategoryShortInfoDto>> GetAllAsync()
        {
            try
            {
                var categories = _mapper.Map<List<CategoryShortInfoDto>>(await _repository.GetAllAsync());
                return categories;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetAllAsync Category ERROR: {ex.Message}");
                throw new ServiceGetAllException(ex.Message);
            }
        }

        public async Task<CategoryFullInfoDto> GetByIdAsync(Guid categoryId)
        {
            try
            {
                var category = _mapper.Map<CategoryFullInfoDto>(await _repository.GetByIdAsync(categoryId));
                return category;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetByIdAsync Category ERROR: {ex.Message}");
                throw new ServiceGetByIdException(ex.Message);
            }
        }

        public async Task<EditCategoryDto> UpdateAsync(EditCategoryDto newCategoryDto)
        {
            try
            {
                var newCategory = await _repository.GetByIdAsync(newCategoryDto.Id);
                _mapper.Map<EditCategoryDto,Category>(newCategoryDto, newCategory);
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