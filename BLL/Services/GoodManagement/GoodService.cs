using BLL.Services.GenericService;
using BLL.Services.GoodManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;

namespace BLL.Services.GoodManagement
{
    public class GoodService : GenericService<Good>, IGoodService
    {
        public GoodService(IRepository<Good> repository) : base(repository) { }
    }
}