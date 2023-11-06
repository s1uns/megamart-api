using Core.Models;

namespace BLL.Services.GenericService.Interfaces
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);

        Task DeleteAsync(Guid entityId);

        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid entityId);
        Task<T> GetByPredicateAsync(Func<T, bool> predicate);

        Task<T> UpdateAsync(T entity);
    }
}
