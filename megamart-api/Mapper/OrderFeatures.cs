using AutoMapper;
using Core.Models;
using Infrustructure.Dto.Goods;
using Infrustructure.Dto.Order;

namespace megamart_api.Mapper
{
    public class OrderFeatures : Profile
    {
        public OrderFeatures()
        {
            CreateMap<Order, OrderFullInfoDto>();
            CreateMap<Order, OrderShortInfoDto>();
        }
    }
}
