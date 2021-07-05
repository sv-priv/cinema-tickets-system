using Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrderDetails(Guid id);
    }
}
