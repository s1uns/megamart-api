using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task<List<T>> GetAllAsync();

        public Task<T> GetByIdAsync(Guid id);

        public Task<T> GetByPredicateAsync(Func<T, bool> predicate);
        public Task<List<T>> GetRangeAsync(Func<T, bool> predicate); 
        public Task<T> AddAsync(T entity);
        public Task<List<T>> AddRangeAsync(List<T> entities);

        public Task<T> UpdateAsync(T entity);

        public Task DeleteAsync(Guid id);
    }
}