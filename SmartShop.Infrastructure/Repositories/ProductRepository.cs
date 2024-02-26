
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.Model.Model;
using SmartShop.Context.Context;
using SmartShop.Application1.Contracts;
using SmartShop.Dtos.Dtos;

namespace SmartShop.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
         private SmartShopDBContext _context;
        public ProductRepository(SmartShopDBContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Product> SerchByName(string name)
        {

            return _context.Products.Where(u => u.Name.ToLower().Contains(name));
        }
    }
}
