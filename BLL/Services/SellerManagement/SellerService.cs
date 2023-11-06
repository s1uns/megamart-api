using BLL.Services.GenericService;
using BLL.Services.SellerManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;


namespace BLL.Services.SellerManagement
{
    public class SellerService : GenericService<Seller>, ISellerService
    {
        public SellerService(IRepository<Seller> repository) : base(repository) { }
    }
}