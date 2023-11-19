using BLL.Services.GenericService;
using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using DAL.Repository;
using DAL.Repository.Interface;
using Infrustructure.ErrorHandling.Services.GenericException;
using Microsoft.Extensions.Logging;

namespace BLL.Services.GoodManagement
{
    public class GoodService : GenericService<Good>, IGoodService
    {
        private readonly IRepository<Good> _repository;
        private readonly ILogger<GoodService> _logger;
        private readonly IRepository<GoodOption> _optionRepository;

        public GoodService(IRepository<Good> repository, ILogger<GoodService> logger, IRepository<GoodOption> optionRepository) : base(repository, logger) 
        {
            _optionRepository = optionRepository;
        }

        public override async Task<Good> AddAsync(Good entity)
        {
            try
            {
                await _repository.AddAsync(entity);

                var options = entity.GoodOptions.ToList();

                await _optionRepository.AddRangeAsync(options);
                return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddAsync Good ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }
    }
}