
using SmartShop.Application1.Contracts;
using SmartShop.Context.Context;
using SmartShop.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order, int>, IOrderRepository
    {
        private SmartShopDBContext _context;
        
        public OrderRepository(SmartShopDBContext context)
            : base(context)
        {
            _context = context;
          
        }

        public IQueryable<Order> OrderdByDateAscending()
        {
            return _context.Orders.OrderBy(o => o.OrderDate);
        }

        public IQueryable<Order> OrderdByDateDescending()
        {
            return _context.Orders.OrderByDescending(o => o.OrderDate);
        }

      
        public IQueryable<Order> SearchByOrderDate(DateTime dateTime)
        {
            return _context.Orders.Where(o => o.OrderDate == dateTime);
        }

        public IQueryable<Order> SearchByUser(int userId)
        {
            return _context.Orders.Where(o => o.UserID == userId);
        }
    }
}
