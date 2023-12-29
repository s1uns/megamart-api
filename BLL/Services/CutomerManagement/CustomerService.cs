using AutoMapper;
using BLL.Services.CutomerManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;
using Microsoft.Extensions.Logging;

namespace BLL.Services.CutomerManagement
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _repository;
        private readonly ILogger<CustomerService> _logger;
        private readonly IMapper _mapper;
        public CustomerService(IRepository<Customer> repository, ILogger<CustomerService> logger, IMapper mapper) 
        { 
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

    }
}