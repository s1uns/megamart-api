/*using AutoMapper;
using BLL.Services.DeliveryAddressManagement;
using BLL.Services.GenericService;
using BLL.Services.OrderManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Microsoft.Extensions.Logging;

namespace BLL.Services.OrderManagement
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IMapper _mapper;
        public OrderService(IRepository<Order> repository, ILogger<OrderService> logger, IMapper mapper) : base(repository, logger, mapper) { }
    }
}*/