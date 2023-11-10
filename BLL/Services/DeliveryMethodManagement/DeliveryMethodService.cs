using BLL.Services.DeliveryMethodManagement.Interfaces;
using BLL.Services.GenericService;
using Core.Models;
using DAL.Repository.Interface;

namespace BLL.Services.DeliveryMethodManagement
{
    public class DeliveryMethodService : GenericService<DeliveryMethod>, IDeliveryMethodService
    {
        public DeliveryMethodService(IRepository<DeliveryMethod> repository) : base(repository) { }
    }
}