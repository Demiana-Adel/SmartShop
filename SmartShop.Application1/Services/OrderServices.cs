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
    public class OrderServices :IOrderServices
    {
        private IOrderRepository _orderRepository;
        private IMapper _mapper;
        public OrderServices(IOrderRepository orderRepository , IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public List<OrderDtos> GetAllPagination(int num, int ord)
        {

            var orsers = _orderRepository.GetAll().Skip(num * ord).Take(ord).ToList();
            var AllOrsers = _mapper.Map<List<OrderDtos>>(orsers);
            return AllOrsers;
        }

        public OrderDtos GetOrder(int id)
        {
            if (id != 0)
            {
                var order = _orderRepository.GetById(id);
                var orderDto = _mapper.Map<OrderDtos>(order);
                return orderDto;
            }
            else
            {
                return null;
            }
        }

        public OrderDtos AddOrder(OrderDtos order)
        {
            var AddOrder = _mapper.Map<Order>(order);
            var data = _orderRepository.Add(AddOrder);
            _orderRepository.Save();
            var orderDto = _mapper.Map<OrderDtos>(data);
            return orderDto;
        }

        public OrderDtos UpdateOrder(OrderDtos order)
        {
            var UpdateOrder = _mapper.Map<Order>(order);
            var data = _orderRepository.Update(UpdateOrder);
            _orderRepository.Save();
            var orderDto = _mapper.Map<OrderDtos>(data);
            return orderDto;
        }

        public void DeleteOrder(OrderDtos order)
        {
            var DeleteOrder = _mapper.Map<Order>(order);
            _orderRepository.Delete(DeleteOrder);
            _orderRepository.Save();
        }

       
    }
}
