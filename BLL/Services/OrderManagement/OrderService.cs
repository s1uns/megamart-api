using BLL.Services.GenericService;
using BLL.Services.OrderManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;

namespace BLL.Services.OrderManagement
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        public OrderService(IRepository<Order> repository) : base(repository) { }
    }
}