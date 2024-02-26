
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Services
{
    public interface IUserServices
    {
        List<UserDtos> GetAllPagination(int num, int user);
        UserDtos GetUser(int id);
        UserDtos AddUser(UserDtos user);
        UserDtos UpdateUser(UserDtos user);
        void DeleteUser(UserDtos user);
        UserDtos FindUser(string username, string password);
    }
}
