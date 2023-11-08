using BLL.Services.GenericService.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.ErrorHandling.Services.GenericException;
using Microsoft.Extensions.Logging;

namespace BLL.Services.GenericService
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;
        private readonly ILogger<GenericService<T>> _logger;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public GenericService(IRepository<T> repository, ILogger<GenericService<T>> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        public async Task<T> AddAsync(T entity)
        {
            try
            {
                await _repository.AddAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddAsync {nameof(T)} ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task DeleteAsync(Guid entityId)
        {
            try
            {
                await _repository.DeleteAsync(entityId);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteAsync {nameof(T)} ERROR: {ex.Message}");
                throw new ServiceDeleteException(ex.Message);
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                return entities;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetAllAsync {nameof(T)} ERROR: {ex.Message}");
                throw new ServiceGetAllException(ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(Guid entityId)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(entityId);
                return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetByIdAsync {nameof(T)} ERROR: {ex.Message}");
                throw new ServiceGetByIdException(ex.Message);
            }
        }

        public async Task<T> GetByPredicateAsync(Func<T, bool> predicate)
        {
            try
            {
                var entity = await _repository.GetByPredicateAsync(predicate);
                return entity;
            }
            catch (Exception ex)
            {
                throw new ServiceGetByPredicateException(ex.Message);
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                await _repository.UpdateAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateAsync {nameof(T)} ERROR: {ex.Message}");
                throw new ServiceUpdateException(ex.Message);
            }
        }
    }
}