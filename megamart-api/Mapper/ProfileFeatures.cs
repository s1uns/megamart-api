﻿using AutoMapper;
using Core.Models;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.UserProfile;

namespace megamart_api.Mapper
{
    public class ProfileFeatures : Profile
    {
        public ProfileFeatures()
        {
            CreateMap<Customer, CustomerProfileDto>()
                .ForCtorParam(nameof(CustomerProfileDto.FullName),
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(c => c.Orders, otp => otp.MapFrom(src => src.Orders));

            CreateMap<Seller, SellerProfileDto>()
                .ForMember(c => c.Goods, otp => otp.MapFrom(src => src.Goods));

            CreateMap<UpdateSellerProfileDto, Seller>();
            CreateMap<UpdateCustomerProfileDto, Customer>();

            CreateMap<Seller, GoodsSellerInfoDto>()
                .ForCtorParam(nameof(GoodsSellerInfoDto.SellerId), otp => otp.MapFrom(src => src.Id))
                .ForCtorParam(nameof(GoodsSellerInfoDto.SellerName), otp => otp.MapFrom(src => src.Name))
                .ForCtorParam(nameof(GoodsSellerInfoDto.SellerPicUrl), otp => otp.MapFrom(src => src.ProfilePicUrl));
        }
    }
}
