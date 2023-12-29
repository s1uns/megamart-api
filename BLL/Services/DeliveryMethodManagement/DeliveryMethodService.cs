using AutoMapper;
using BLL.Services.DeliveryMethodManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Infrustructure.ErrorHandling.Services.GenericException;
using Microsoft.Extensions.Logging;
using Infrustructure.Dto.DeliveryMethods;

namespace BLL.Services.DeliveryMethodManagement
{
    public class DeliveryMethodService : IDeliveryMethodService
    {
        private readonly IRepository<DeliveryMethod> _repository;
        private readonly ILogger<DeliveryMethodService> _logger;
        private readonly IMapper _mapper;
        public DeliveryMethodService(IRepository<DeliveryMethod> repository, ILogger<DeliveryMethodService> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CreateDeliveryMethodDto> AddAsync(CreateDeliveryMethodDto deliveryMethodDto)
        {
            try
            {
                var deliveryMethod = _mapper.Map<DeliveryMethod>(deliveryMethodDto);
                await _repository.AddAsync(deliveryMethod);
                return deliveryMethodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.AddAsync DeliveryMethod ERROR: {ex.Message}");
                throw new ServiceAddException(ex.Message);
            }
        }

        public async Task DeleteAsync(Guid deliveryMethodId)
        {
            try
            {
                await _repository.DeleteAsync(deliveryMethodId);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.DeleteAsync DeliveryMethod ERROR: {ex.Message}");
                throw new ServiceDeleteException(ex.Message);
            }
        }

        public async Task<List<DeliveryMethodFullInfoDto>> GetAllAsync()
        {
            try
            {
                var categories = _mapper.Map<List<DeliveryMethodFullInfoDto>>(await _repository.GetAllAsync());
                return categories;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetAllAsync DeliveryMethod ERROR: {ex.Message}");
                throw new ServiceGetAllException(ex.Message);
            }
        }

        public async Task<DeliveryMethodFullInfoDto> GetByIdAsync(Guid deliveryMethodId)
        {
            try
            {
                var deliveryMethod = _mapper.Map<DeliveryMethodFullInfoDto>(await _repository.GetByIdAsync(deliveryMethodId));
                return deliveryMethod;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetByIdAsync DeliveryMethod ERROR: {ex.Message}");
                throw new ServiceGetByIdException(ex.Message);
            }
        }

        public async Task<EditDeliveryMethodDto> UpdateAsync(EditDeliveryMethodDto newDeliveryMethodDto)
        {
            try
            {
                var newDeliveryMethod = await _repository.GetByIdAsync(newDeliveryMethodDto.Id);
                _mapper.Map<EditDeliveryMethodDto, DeliveryMethod>(newDeliveryMethodDto, newDeliveryMethod);
                await _repository.UpdateAsync(newDeliveryMethod);
                return newDeliveryMethodDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateAsync DeliveryMethod ERROR: {ex.Message}");
                throw new ServiceUpdateException(ex.Message);
            }
        }
    }
}