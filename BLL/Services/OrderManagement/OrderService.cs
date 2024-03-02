using AutoMapper;
using BLL.Services.OrderManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Microsoft.Extensions.Logging;

namespace BLL.Services.OrderManagement
{
    public class OrderService : IOrderService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IMapper _mapper;
        public OrderService(IRepository<Order> repository, ILogger<OrderService> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
    }
}