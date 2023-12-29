/*using AutoMapper;
using BLL.Services.DeliveryAddressManagement;
using BLL.Services.GenericService;
using BLL.Services.OrderPositionManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Microsoft.Extensions.Logging;

namespace BLL.Services.OrderPositionManagement
{
    public class OrderPositionService : GenericService<OrderPosition>, IOrderPositionService
    {
        private readonly ILogger<OrderPositionService> _logger;
        private readonly IMapper _mapper;
        public OrderPositionService(IRepository<OrderPosition> repository, ILogger<OrderPositionService> logger, IMapper mapper) : base(repository, logger, mapper) { }
    }
}*/