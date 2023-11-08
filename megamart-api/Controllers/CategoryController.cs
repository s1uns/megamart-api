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


        [HttpGet("categories")]
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
    }
}
