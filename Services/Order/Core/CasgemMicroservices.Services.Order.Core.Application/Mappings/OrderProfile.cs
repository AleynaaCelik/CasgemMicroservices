using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Mappings
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<ResultOrderDto, Domain.Entities.Order>().ReverseMap();
            CreateMap<CreateOrderDto, Domain.Entities.Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Domain.Entities.Order>().ReverseMap();
        }
    }
}
