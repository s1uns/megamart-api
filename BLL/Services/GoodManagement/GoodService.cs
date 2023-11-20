using AutoMapper;
using BLL.Services.GenericService;
using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using DAL.Repository;
using DAL.Repository.Interface;
using Infrustructure.Dto.Goods;
using Infrustructure.ErrorHandling.Services.GenericException;
using Microsoft.Extensions.Logging;

namespace BLL.Services.GoodManagement
{
    public class GoodService : IGoodService
    {
        private readonly IRepository<Good> _repository;
        private readonly ILogger<GoodService> _logger;
        private readonly IRepository<GoodOption> _optionRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GoodService(IRepository<Good> repository, ILogger<GoodService> logger, IRepository<GoodOption> optionRepository, IRepository<Category> categoryRepository, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _optionRepository = optionRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<CreateGoodDto> AddAsync(CreateGoodDto goodDto)
        {
            try
            {
                var entity = _mapper.Map<Good>(goodDto);
                entity.Categories = await _categoryRepository.GetRangeAsync(c => goodDto.CategoryIds.Contains(c.Id));
                entity.CreationStatus = Core.Enums.GoodCreationStatus.JustCreated;
                entity.AvailabilityStatus = Core.Enums.GoodAvailabilityStatus.Available;
                await _repository.AddAsync(entity);

                await _optionRepository.AddRangeAsync(entity.GoodOptions.ToList());
                return goodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddAsync Good ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task<EditGoodDto> UpdateAsync(EditGoodDto newGoodDto)
        {
            try
            {
                var newGood = await _repository.GetByIdAsync(newGoodDto.Id);
                _mapper.Map<Good>(newGoodDto);

                return newGoodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateAsync Good ERROR: {ex.Message}");
                throw new ServiceUpdateException(ex.Message);
            }
        }
    }
}