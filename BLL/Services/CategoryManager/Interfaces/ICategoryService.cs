using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CategoryManager.Interfaces
{
    internal interface ICategoryService
    {
        Task<Category> AddAsync(Category category);

        Task DeleteAsync(Guid categoryId);

        Task<List<Category>> GetAllAsync();

        Task<Category> GetByIdAsync(Guid categoryId);
        Task<Category> GetByPredicateAsync(Func<Category, bool> predicate);

        Task<Category> UpdateAsync(Category category);

    }
}
