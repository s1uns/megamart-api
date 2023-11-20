using AutoMapper;
using Core.Models;
using Infrustructure.Dto.Categories;

namespace megamart_api.Mapper
{
    public class CategoryFeatures : Profile
    {
        public CategoryFeatures()
        {
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<EditCategoryDto, Category>();
            CreateMap<Category, CategoryFullInfoDto>();
            CreateMap<Category, CategoryShortInfoDto>()
                .ForMember(c => c.Name, otp => otp.MapFrom(src => src.Name))
                .ForMember(c => c.Color, otp => otp.MapFrom(src => src.Color));
;
        }
    }
}
