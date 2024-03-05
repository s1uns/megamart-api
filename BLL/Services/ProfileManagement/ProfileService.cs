using AutoMapper;
using BLL.Services.GoodManagement;
using BLL.Services.ProfileManagement.Interface;
using Core.Models;
using Core.Result;
using DAL.Repository.Interface;
using Infrustructure.Dto.UserProfile;
using Infrustructure.ErrorHandling.Errors.Base;
using Infrustructure.ErrorHandling.Errors.ServiceErrors;
using Infrustructure.Extensions;
using megamart_api.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ProfileManagement
{
    public class ProfileService : IProfileService
    {
        private readonly ILogger<ProfileService> _logger;
        private readonly IMapper _mapper;
        private readonly MegamartContext _context;
        private readonly IHttpContextAccessor _contextAccessor;


        public ProfileService(ILogger<ProfileService> logger, IMapper mapper, MegamartContext context, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<Result<CustomerProfileDto, Error>> GetCustomerProfileAsync(Guid customerId)
        {
            try
            {
                var customer = await _context
                    .Customers
                    .Include(c => c.Orders)
                    .FirstOrDefaultAsync(x => x.Id == customerId);

                if (customer is null)
                {
                    return ProfileServiceErrors.UserNotFoundError;
                }

                return _mapper.Map<CustomerProfileDto>(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetCustomerProfileAsync ERROR: {ex.Message}");

                return ProfileServiceErrors.GetCustomerProfileError;
            }
        }

        public async Task<Result<SellerProfileDto, Error>> GetSellerProfileAsync(Guid sellerId)
        {
            try
            {
                var seller = await _context
                    .Sellers
                    .Include(c => c.Goods)
                    .FirstOrDefaultAsync(x => x.Id == sellerId);

                if (seller is null)
                {
                    return ProfileServiceErrors.UserNotFoundError;
                }

                return _mapper.Map<SellerProfileDto>(seller);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetSellerProfileAsync ERROR: {ex.Message}");

                return ProfileServiceErrors.GetSellerProfileError;
            }
        }

        public async Task<Result<CustomerProfileDto, Error>> GetOwnCustomerProfileAsync()
        {
            try
            {
                var isIdValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (isIdValid is false)
                {
                    return UserErrors.InvalidUserId;
                }

                var customer = await _context
                    .Customers
                    .Include(c => c.Orders)
                    .FirstOrDefaultAsync(x => x.Id == userId);

                if (customer is null)
                {
                    return ProfileServiceErrors.UserNotFoundError;
                }

                return _mapper.Map<CustomerProfileDto>(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetOwnCustomerProfileAsync ERROR: {ex.Message}");

                return ProfileServiceErrors.GetCustomerProfileError;
            }
        }

        public async Task<Result<SellerProfileDto, Error>> GetOwnSellerProfileAsync()
        {
            try
            {
                var isIdValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (isIdValid is false)
                {
                    return UserErrors.InvalidUserId;
                }

                var seller = await _context
                    .Sellers
                    .Include(c => c.Goods)
                    .FirstOrDefaultAsync(x => x.Id == userId);

                if (seller is null)
                {
                    return ProfileServiceErrors.UserNotFoundError;
                }

                return _mapper.Map<SellerProfileDto>(seller);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.GetOwnSellerProfileAsync ERROR: {ex.Message}");

                return ProfileServiceErrors.GetSellerProfileError;
            }
        }

        public async Task<Result<CustomerProfileDto, Error>> UpdateCustomerProfileAsync(UpdateCustomerProfileDto customerProfileDto)
        {
            try
            {
                var isIdValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (isIdValid is false)
                {
                    return UserErrors.InvalidUserId;
                }

                var customer = await _context
                    .Customers
                    .FirstOrDefaultAsync(x => x.Id == userId);

                if (customer is null)
                {
                    return ProfileServiceErrors.UserNotFoundError;
                }

                _mapper.Map(customerProfileDto, customer);
                await _context.SaveChangesAsync();

                return _mapper.Map<CustomerProfileDto>(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateCustomerProfileAsync ERROR: {ex.Message}");

                return ProfileServiceErrors.UpdateProfileError;
            }
        }

        public async Task<Result<SellerProfileDto, Error>> UpdateSellerProfileAsync(UpdateSellerProfileDto sellerProfileDto)
        {
            try
            {
                var isIdValid = _contextAccessor.TryGetUserId(out Guid userId);

                if (isIdValid is false)
                {
                    return UserErrors.InvalidUserId;
                }

                var seller = await _context
                    .Sellers
                    .FirstOrDefaultAsync(x => x.Id == userId);

                if (seller is null)
                {
                    return ProfileServiceErrors.UserNotFoundError;
                }

                _mapper.Map(sellerProfileDto, seller);
                await _context.SaveChangesAsync();

                return _mapper.Map<SellerProfileDto>(seller);
            }
            catch (Exception ex)
            {
                _logger.LogError($"BLL.UpdateSellerProfileAsync ERROR: {ex.Message}");

                return ProfileServiceErrors.UpdateProfileError;
            }
        }
    }
}
