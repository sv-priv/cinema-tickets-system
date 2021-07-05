using Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderDetails(Guid id);
    }
}
