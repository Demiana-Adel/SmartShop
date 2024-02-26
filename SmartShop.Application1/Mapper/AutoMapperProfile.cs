using AutoMapper;
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Mapper
{
    public class AutoMapperProfile :Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<User ,UserDtos>().ReverseMap();
            CreateMap<Category, CategoryDtos>().ReverseMap();
            CreateMap<Product , ProductDtos>().ReverseMap();
            CreateMap<Order , OrderDtos >().ReverseMap();
            CreateMap<OrdersItems , OrdersItemsDtos>().ReverseMap();

        }

    }
}
