using BLL.Services.CategoryManager;
using BLL.Services.CategoryManager.Interfaces;
using Core.Models;
using Core.Result;
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

        /// <summary>
        /// Return the list of all categories
        /// </summary>
        /// <remarks>
        /// If the operation is successful, it will return a List of CategoryShortInfoDto.
        /// If there is a bad request, it will return an Error.
        /// </remarks>
        /// <returns>An IActionResult representing the result of the operation.</returns>
        [HttpGet("list")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllAsync();
            return this.CreateResponse(result);

        }

        [HttpPost("create")]
        public async Task<IActionResult> AddCategory([FromBody] CreateCategoryDto categoryDto)
        {
            var result = await _categoryService.AddAsync(categoryDto);
            return this.CreateResponse(result);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            return this.CreateResponse(result);

        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCategory([FromBody] EditCategoryDto categoryDto)
        {
            var result = await _categoryService.UpdateAsync(categoryDto);
            return this.CreateResponse(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {

            var result = await _categoryService.DeleteAsync(id);
            return this.CreateResponse(result);

        }
    }
}
