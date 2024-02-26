
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Contracts
{
    public interface IUserRepository :IRepository<User, int>
    {
       User Find(string username, string password);
        
    }
}
