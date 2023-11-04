using Core.Models;
using DAL.Repository.Interface;
using megamart_api.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Result<List<T>>> GetAllAsync()
        {
            try
            {
                if (_dbSet.Count() != 0)
                {
                    var items = _dbSet.ToList();
                    return new Result<List<T>>(isSuccessful: true, data: items);
                }

                return new Result<List<T>>(isSuccessful: true, data: new List<T>());
            }
            catch (Exception ex)
            {
                throw new Exception($"There was a problem during returning the list of entities: {ex.Message}");
            }
        }

        public async Task<Result<T>> GetByIdAsync(int id)
        {
            return await GetByPredicateAsync(x => x.Id.Equals(id));
        }

        public async Task<Result<T>> GetByPredicateAsync(Func<T, bool> predicate)
        {
            try
            {
                var item = (await GetAllAsync()).Data.FirstOrDefault(predicate);

                if (item == null)
                {
                    return new Result<T>(isSuccessful: false, message: "Item is not found.");
                }

                return new Result<T>(isSuccessful: true, data: item);
            }
            catch (Exception ex)
            {
                return new Result<T>(isSuccessful: false, message: $"Failed to get item. Exception: {ex.Message}");
            }
        }

        public async Task<Result<bool>> AddAsync(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                await SaveChanges();

                return new Result<bool>(isSuccessful: true);
            }
            catch (Exception ex)
            {
                return new Result<bool>(isSuccessful: false, message: $"Failed to add item. Exception: {ex.Message}");
            }
        }

        public async Task<Result<bool>> UpdateAsync(int id, T newEntity)
        {
            try
            {

                if (id != -1)
                {
                    var baseEntity = (await GetByIdAsync(id)).Data;
                    _dbSet.Entry(baseEntity).CurrentValues.SetValues(newEntity);
                    await SaveChanges();

                    return new Result<bool>(isSuccessful: true);
                }
                return new Result<bool>(isSuccessful: false, message: "Object with the specified Id not found.");
            }
            catch (Exception ex)
            {
                return new Result<bool>(isSuccessful: false, message: $"Failed to update item. Exception: {ex.Message}");
            }
        }

        public async Task<Result<bool>> DeleteAsync(int id)
        {
            try
            {

                var entity = (await GetByIdAsync(id)).Data;

                if (id != -1)
                {
                    _dbSet.Remove(entity);
                    await SaveChanges();

                    return new Result<bool>(isSuccessful: true);
                }
                return new Result<bool>(isSuccessful: false, message: "Object with the specified Id not found.");
            }
            catch (Exception ex)
            {
                return new Result<bool>(isSuccessful: false, message: $"Failed to delete item. Exception: {ex.Message}");
            }
        }
    }
}