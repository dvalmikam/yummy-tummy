using AutoMapper;
using yummy_tummy.Controllers.Resources;
using yummy_tummy.Models;

namespace yummy_tummy.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            //domain to api
            CreateMap<MenuItem, MenuResource>();
            CreateMap<Order, OrderResource>();
            CreateMap<OrderItem, OrderItemResource>();

            //api to domain
            CreateMap<OrderResource,Order>()
            .ForMember(e=>e.OrderTotal,opt=>opt.MapFrom(ss=>ss.OrderTotal));
        }
    }
}