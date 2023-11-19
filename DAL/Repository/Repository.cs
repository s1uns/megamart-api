using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.ErrorHandling.Repository.Exceptions;
using megamart_api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MegamartContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly ILogger<Repository<T>> _logger;

        public Repository(MegamartContext context, ILogger<Repository<T>> logger)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _logger = logger;
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
                _logger.LogError($"DAL.GetAllAsync ERROR: {ex.Message}");
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
                _logger.LogError($"DAL.GetByIdAsync ERROR: {ex.Message}");
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
                _logger.LogError($"DAL.GetByPredicateAsync ERROR: {ex.Message}");
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
                _logger.LogError($"DAL.AddAsync ERROR: {ex.Message}");
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
                _logger.LogError($"DAL.UpdateAsync ERROR: {ex.Message}");
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
                _logger.LogError($"DAL.DeleteAsync ERROR: {ex.Message}");
                throw new RepositoryDeleteException($"Failed to delete {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<List<T>> AddRangeAsync(List<T> entities)
        {
            try
            {
                await _dbSet.AddRangeAsync(entities);
                await SaveChangesAsync();
                return entities;
            }
            catch (Exception ex)
            {
                _logger.LogError($"DAL.DeleteAsync ERROR: {ex.Message}");
                throw new RepositoryDeleteException($"Failed to delete {nameof(T)}. Exception: {ex.Message}");
            }
        }
    }
}