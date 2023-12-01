using AutoMapper;
using Core.Models;
using Infrustructure.Dto.DeliveryMethods;

namespace megamart_api.Mapper
{
    public class DeliveryMethodFeatures : Profile
    {
        public DeliveryMethodFeatures()
        {
            CreateMap<CreateDeliveryMethodDto, DeliveryMethod>();
            CreateMap<EditDeliveryMethodDto, DeliveryMethod>();
            CreateMap<DeliveryMethod, DeliveryMethodFullInfoDto>();
        }
    }
}
