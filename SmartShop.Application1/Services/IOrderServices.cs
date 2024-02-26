using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Services
{
    public interface IOrderServices
    {
        List<OrderDtos> GetAllPagination(int num, int ord);
        OrderDtos GetOrder(int id);
        OrderDtos AddOrder(OrderDtos order);
        OrderDtos UpdateOrder(OrderDtos order);
        void DeleteOrder(OrderDtos order);
    }
}
