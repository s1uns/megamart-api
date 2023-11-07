using BLL.Services.GenericService;
using BLL.Services.OrderPositionManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;

namespace BLL.Services.OrderPositionManagement
{
    public class OrderPositionService : GenericService<OrderPosition>, IOrderPositionService
    {
        public OrderPositionService(IRepository<OrderPosition> repository) : base(repository) { }
    }
}