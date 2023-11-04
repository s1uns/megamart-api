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
        Task<Result<List<T>>> GetAllAsync();

        Task<Result<T>> GetByIdAsync(int id);

        Task<Result<T>> GetByPredicateAsync(Func<T, bool> predicate);

        Task<Result<bool>> AddAsync(T entity);

        Task<Result<bool>> UpdateAsync(int id, T newEntity);

        Task<Result<bool>> DeleteAsync(int id);
    }
}