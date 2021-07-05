using Domain.DomainModels;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public Order GetOrderDetails(Guid id)
        {
            return _orderRepository.GetOrderDetails(id);
        }


    }
}
