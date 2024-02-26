using AutoMapper;
using SmartShop.Application1.Contracts;
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserServices(IUserRepository userRepository , IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public List<UserDtos> GetAllPagination(int num, int user)
        {
          
            var users= _userRepository.GetAll().Skip(num * user).Take(user).ToList();
             var AllUser = _mapper.Map<List<UserDtos>>(users);
            return AllUser;
        }

        public UserDtos GetUser(int id)
        {
            var data = _userRepository.GetById(id);
            var userDto=_mapper.Map<UserDtos>(data);
            return userDto;

        }

        public UserDtos AddUser(UserDtos user)
        {
            var AddData = _mapper.Map<User>(user);
            var data = _userRepository.Add(AddData);
            _userRepository.Save();
            var userDto = _mapper.Map<UserDtos>(data);
            return userDto;
        }
        public UserDtos UpdateUser(UserDtos user)
        {
            var updateData =_mapper.Map<User>(user);
            var data = _userRepository.Update(updateData);
            _userRepository.Save();
            var userDto = _mapper.Map<UserDtos>(data);
            return userDto;
        }
        public void DeleteUser(UserDtos user)
        {
            var deleteData=_mapper.Map<User>(user);
            _userRepository.Delete(deleteData);
            _userRepository.Save();
        }

        public UserDtos FindUser(string username, string password)
        {

            var data =_userRepository.Find(username, password);
            var finduser = _mapper.Map<UserDtos>(data);
            return finduser;
        }
    }
}
