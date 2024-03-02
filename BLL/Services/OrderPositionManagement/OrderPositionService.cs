using AutoMapper;
using BLL.Services.OrderPositionManagement.Interfaces;
using Core.Models;
using Microsoft.Extensions.Logging;

namespace BLL.Services.OrderPositionManagement
{
    public class OrderPositionService : IOrderPositionService
    {
        private readonly ILogger<OrderPositionService> _logger;
        private readonly IMapper _mapper;
        public OrderPositionService(ILogger<OrderPositionService> logger, IMapper mapper) 
        { 
            _logger = logger;
            _mapper = mapper;
        }
    }
}