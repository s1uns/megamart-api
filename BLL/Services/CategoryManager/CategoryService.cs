using BLL.Services.CategoryManager.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.ErrorHandling.Services.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CategoryManager
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<Category> AddAsync(Category category)
        {
            try
            {
                await _repository.AddAsync(category);
                return category;
            }
            catch (Exception ex)
            {
                throw new CategoryAddException(ex.Message);
            }

        }

        public async Task DeleteAsync(Guid categoryId)
        {
            try
            {
                await _repository.DeleteAsync(categoryId);
            }
            catch(Exception ex)
            {
                throw new CategoryDeleteException(ex.Message);
            }
        }

        public async Task<List<Category>> GetAllAsync()
        {
            try
            {
                var categories = await _repository.GetAllAsync();
                return categories;
            }
            catch(Exception ex)
            {
                throw new CategoryGetAllException(ex.Message);
            }
        }

        public async Task<Category> GetByIdAsync(Guid categoryId)
        {
            try
            {
                var category = await _repository.GetByIdAsync(categoryId);
                return category;
            }
            catch(Exception ex)
            {
                throw new CategoryGetByIdException(ex.Message);
            }
        }

        public async Task<Category> GetByPredicateAsync(Func<Category, bool> predicate)
        {
            try
            {
                var category = await _repository.GetByPredicateAsync(predicate);
                return category;
            }
            catch(Exception ex)
            {
                throw new CategoryGetByPredicateException(ex.Message);
            }
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            try
            {
                await _repository.UpdateAsync(category);
                return category;
            }
            catch (Exception ex)
            {
                throw new CategoryUpdateException(ex.Message);
            }
        }
    }
}