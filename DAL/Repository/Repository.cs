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


        public async Task SaveChanges()
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
                throw new GetAllException($"There was a problem during returning the list of {nameof(T)} entities: {ex.Message}");
            }
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                var item = await _dbSet.FindAsync(id);

                if (item is null)
                {
                    throw new IdNotRetrievedException($"{nameof(T)} with the specified Id not found.");
                }

                return item;
            }
            catch (Exception ex)
            {
                throw new GetByIdException($"Failed to get {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<T> GetByPredicateAsync(Func<T, bool> predicate)
        {
            try
            {
                var item = (await GetAllAsync()).FirstOrDefault(predicate);

                if (item is null)
                {
                    throw new PredicateNotFoundException($"{nameof(T)} with the specified predicate not found.");
                }

                return item;
            }
            catch (Exception ex)
            {
                throw new GetByPredicateException($"Failed to get {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                await SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw new AddException($"Failed to add {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task<T> UpdateAsync(Guid id, T newEntity)
        {
            try
            {

                var baseEntity = await GetByIdAsync(id);

                if (baseEntity is null)
                {
                    throw new IdNotRetrievedException($"{nameof(T)} with the specified Id not found.");
                }
                _dbSet.Entry(baseEntity).CurrentValues.SetValues(newEntity);
                    await SaveChanges(); 
                return baseEntity;
            }
            catch (Exception ex)
            {
                throw new UpdateException($"Failed to update {nameof(T)}. Exception: {ex.Message}");
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {

                var item = await _dbSet.FindAsync(id);

                if (item is null)
                {
                    throw new IdNotRetrievedException($"{nameof(T)} with the specified Id not found.");
                }

                _dbSet.Remove(item);
                await SaveChanges();
            }
            catch (Exception ex)
            {
                throw new DeleteException($"Failed to delete {nameof(T)}. Exception: {ex.Message}");
            }
        }
    }
}