using BLL.Services.CategoryManager;
using BLL.Services.CategoryManager.Interfaces;
using Core.Models;
using Infrustructure.Dto.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }


        [HttpGet("list")]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                var allCategories = await _categoryService.GetAllAsync();

                return Ok(allCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.GetAllCategories ERROR: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddCategory([FromBody]CreateCategoryDto categoryDto)
        {
            try
            {
                var result = await _categoryService.AddAsync(categoryDto);
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.AddCategory ERROR: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            try
            {
                var categoryDto = await _categoryService.GetByIdAsync(id);

                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.GetCategory ERROR: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCategory([FromBody] EditCategoryDto categoryDto)
        {
            try
            {
                await _categoryService.UpdateAsync(categoryDto);

                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.UpdateCategory ERROR: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            try
            {
                await _categoryService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.DeleteCategory ERROR: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}
