
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Contracts
{
    public interface IOrderRepository:IRepository<Order , int>
    {
        public IQueryable<Order> SearchByOrderDate(DateTime dateTime);
        IQueryable<Order> OrderdByDateAscending();
        IQueryable<Order> OrderdByDateDescending();
        IQueryable<Order> SearchByUser(int userId);
    }
}
