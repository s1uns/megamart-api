using AutoMapper;
using Core.Models;
using Infrustructure.Dto.Categories;
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
                .ForMember(c => c.SellerName, otp => otp.MapFrom(src => src.Seller.Name));
        }
    }
}
