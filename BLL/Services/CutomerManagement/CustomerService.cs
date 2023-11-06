using BLL.Services.CutomerManagement.Interfaces;
using BLL.Services.GenericService;
using Core.Models;
using DAL.Repository.Interface;

namespace BLL.Services.CutomerManagement
{
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        public CustomerService(IRepository<Customer> repository) : base(repository) { }

    }
}