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
                .ForMember(c => c.BackgroundColor, otp => otp.MapFrom(src => src.BackgroundColor))
                .ForMember(c => c.FontColor, otp => otp.MapFrom(src => src.FontColor));

            CreateMap<Category,Guid>().ConvertUsing(c => c.Id);
                
        }
    }
}
