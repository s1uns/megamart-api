using AutoMapper;
using Core.Models;
using Infrustructure.Dto.Categories;
using Infrustructure.Dto.GoodOptions;
using Infrustructure.Dto.Goods;

namespace megamart_api.Mapper
{
    public class GoodFeatures : Profile
    {
        public GoodFeatures()
        {
            CreateMap<CreateGoodDto, Good>();
            CreateMap<EditGoodDto, Good>();
            CreateMap<Good, GoodShortInfoDto>()
                .ForMember(g => g.SellerName, otp => otp.MapFrom(src => src.Seller.Name))
                .ForMember(g => g.Categories, otp => otp.MapFrom(src => src.Categories));
            CreateMap<Good, GoodFullInfoDto>()
                .ForMember(g => g.SellerName, otp => otp.MapFrom(src => src.Seller.Name));

            CreateMap<GoodOptionDto, GoodOption>();
            CreateMap<GoodOption, GoodOptionDto>();
        }
    }
}
