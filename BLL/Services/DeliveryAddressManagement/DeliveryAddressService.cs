using BLL.Services.DeliveryAddressManagement.Interfaces;
using BLL.Services.GenericService;
using Core.Models;
using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.DeliveryAddressManagement
{
    public class DeliveryAddressService : GenericService<DeliveryAddress>, IDeliveryAddressService
    {
        public DeliveryAddressService(IRepository<DeliveryAddress> repository) : base(repository) { }

    }
}