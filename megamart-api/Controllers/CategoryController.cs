using BLL.Services.CategoryManager;
using BLL.Services.CategoryManager.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace megamart_api.Controllers
{
    [Route("api/[controller]")]
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
                return BadRequest(ex);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddCategory([FromBody]Category category)
        {
            try
            {
                await _categoryService.AddAsync(category);

                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.AddCategory ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            try
            {
                var category = await _categoryService.GetByIdAsync(id);

                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.GetCategory ERROR: {ex.Message}");
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCategory([FromBody]Category category)
        {
            try
            {
                await _categoryService.UpdateAsync(category);

                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ENDPOINT.Category.UpdateCategory ERROR: {ex.Message}");
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }
    }
}
