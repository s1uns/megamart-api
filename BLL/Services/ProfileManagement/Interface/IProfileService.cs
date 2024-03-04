using Core.Result;
using Infrustructure.Dto.UserProfile;
using Infrustructure.ErrorHandling.Errors.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ProfileManagement.Interface
{
    public interface IProfileService
    {
        public Task<Result<SellerProfileDto, Error>> GetSellerProfileAsync(Guid sellerId);
        public Task<Result<CustomerProfileDto, Error>> GetCustomerProfileAsync(Guid customerId);
        public Task<Result<SellerProfileDto, Error>> GetOwnSellerProfileAsync();
        public Task<Result<CustomerProfileDto, Error>> GetOwnCustomerProfileAsync();
        public Task<Result<SellerProfileDto, Error>> UpdateSellerProfileAsync(UpdateSellerProfileDto sellerProfileDto);
        public Task<Result<CustomerProfileDto, Error>> UpdateCustomerProfileAsync(UpdateCustomerProfileDto customerProfileDto);
    }
}
