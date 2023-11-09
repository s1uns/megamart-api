using BLL.Services.CategoryManager.Interfaces;
using BLL.Services.GenericService;
using Core.Models;
using DAL.Repository.Interface;
using Microsoft.Extensions.Logging;

namespace BLL.Services.CategoryManager
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(IRepository<Category> repository, ILogger<CategoryService> logger) : base(repository, logger) 
        {}
    }
}