
using SmartShop.Application1.Contracts;
using SmartShop.Context.Context;
using SmartShop.Model.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        private SmartShopDBContext _context;
      
        public CategoryRepository(SmartShopDBContext context)
            : base(context)
        {
            _context = context;
           
        }
        public Category SearchByName(string name)
        {
            return _context.Categories.FirstOrDefault(c=>c.Name==name);
        }
    }
}
