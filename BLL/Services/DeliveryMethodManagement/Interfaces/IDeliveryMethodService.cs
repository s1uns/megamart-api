using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.DeliveryMethods;

namespace BLL.Services.DeliveryMethodManagement.Interfaces
{
    public interface IDeliveryMethodService
    {
        public Task<CreateDeliveryMethodDto> AddAsync(CreateDeliveryMethodDto deliveryMethodDto);
        public Task<EditDeliveryMethodDto> UpdateAsync(EditDeliveryMethodDto newDeliveryMethodDto);
        public Task<List<DeliveryMethodFullInfoDto>> GetAllAsync();
        public Task<DeliveryMethodFullInfoDto> GetByIdAsync(Guid deliveryMethodId);
        public Task DeleteAsync(Guid deliveryMethodId);
    }
}