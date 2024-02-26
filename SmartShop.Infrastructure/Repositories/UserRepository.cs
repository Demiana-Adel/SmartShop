
using SmartShop.Application1.Contracts;
using SmartShop.Context.Context;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Infrastructure.Repositories
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        private SmartShopDBContext _context;
        public UserRepository(SmartShopDBContext context) : base(context)
        {
            _context = context;
        }
        public User Find(string username, string password)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
