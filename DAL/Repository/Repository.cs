using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.ErrorHandling.Repository.Exceptions;
using megamart_api.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MegamartContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(MegamartContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public async Task SaveChangesAsync()
        {
            _context.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                if (_dbSet.Count() != 0)
                {
                    var items = _dbSet.ToList();
                    return items;
                }

                return new List<T>();
            }
            catch (Exception ex)
            {
                throw new RepositoryGetAllException($"There was a problem during returning the list of {nameof(T)} entities: {ex.Message}");
            }
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                var item = await _dbSet.FindAsync(id);

                if (item is null)
                {
                    throw new RepositoryIdNotRetrievedException($"{nameof(T)} with the specified Id not found.");
                }

                return item;
            }
            catch (Exception ex)
            {
                throw new RepositoryGetByIdException($"Failed to get {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<T> GetByPredicateAsync(Func<T, bool> predicate)
        {
            try
            {
                var item = (await GetAllAsync()).FirstOrDefault(predicate);

                if (item is null)
                {
                    throw new RepositoryPredicateNotFoundException($"{nameof(T)} with the specified predicate not found.");
                }

                return item;
            }
            catch (Exception ex)
            {
                throw new RepositoryGetByPredicateException($"Failed to get {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                await SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryAddException($"Failed to add {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                if (!_dbSet.Any(e => e.Id == entity.Id))
                {
                    throw new RepositoryIdNotRetrievedException($"{nameof(T)} with the specified Id not found.");
                }

                _dbSet.Update(entity);
                await SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryUpdateException($"Failed to update {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {

                var item = await _dbSet.FindAsync(id);

                if (item is null)
                {
                    throw new RepositoryIdNotRetrievedException($"{nameof(T)} with the specified Id not found.");
                }

                _dbSet.Remove(item);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryDeleteException($"Failed to delete {nameof(T)}. Exception: {ex.Message}");
            }
        }
    }
}