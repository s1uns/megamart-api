using AutoMapper;
using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.Goods;
using Infrustructure.ErrorHandling.Services.GenericException;
using Microsoft.Extensions.Logging;

namespace BLL.Services.GoodManagement
{
    public class GoodService : IGoodService
    {
        private readonly IRepository<Good> _repository;
        private readonly ILogger<GoodService> _logger;
        private readonly IRepository<GoodOption> _optionsRepository;
        private readonly IMapper _mapper;

        public GoodService(IRepository<Good> repository, ILogger<GoodService> logger, IRepository<GoodOption> optionRepository, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _optionsRepository = optionRepository;
        }

        public async Task<CreateGoodDto> AddAsync(CreateGoodDto goodDto)
        {
            try
            {
                //TODO: for authorized seller add getting his id piece
                var entity = _mapper.Map<Good>(goodDto);
                await _repository.AddAsync(entity);

                await _optionsRepository.AddRangeAsync(entity.GoodOptions.ToList());
                return goodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddAsync Good ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task DeleteAsync(Guid goodId)
        {
            try
            {
                await _repository.DeleteAsync(goodId);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteAsync Good ERROR: {ex.Message}");
                throw new ServiceDeleteException(ex.Message);
            }
        }

        public async Task<List<GoodShortInfoDto>> GetAllAsync()
        {
            try
            {
                var categories = _mapper.Map<List<GoodShortInfoDto>>(await _repository.GetAllAsync());
                return categories;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetAllAsync Good ERROR: {ex.Message}");
                throw new ServiceGetAllException(ex.Message);
            }
        }

        public async Task<GoodFullInfoDto> GetByIdAsync(Guid goodId)
        {
            try
            {
                var good = _mapper.Map<GoodFullInfoDto>(await _repository.GetByIdAsync(goodId));
                return good;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetByIdAsync Good ERROR: {ex.Message}");
                throw new ServiceGetByIdException(ex.Message);
            }
        }

        public async Task<EditGoodDto> UpdateAsync(EditGoodDto newGoodDto)
        {
            try
            {
                var newGood = await _repository.GetByIdAsync(newGoodDto.Id);
                _mapper.Map<Good>(newGoodDto);
                await _repository.UpdateAsync(newGood);
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
