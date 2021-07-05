using Domain.DomainModels;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation
{

    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepositorty;
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IRepository<Order> _orderRepositorty;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<EmailMessage> _mailRepository;


        public ShoppingCartService(IRepository<ShoppingCart> shoppingCartRepository,
                                   IRepository<Order> orderRepositorty,
                                   IUserRepository userRepository,
                                   IRepository<Ticket> ticketRepository,
                                   IRepository<EmailMessage> mailRepository)
        {
            _shoppingCartRepositorty = shoppingCartRepository;
            _userRepository = userRepository;
            _orderRepositorty = orderRepositorty;
            _ticketRepository = ticketRepository;
            _mailRepository = mailRepository;
        }

        public bool deleteOrderedTicketFromShoppingCart(string userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public bool deleteTicketFromShoppingCart(string userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart getShoppingCartInfo(string userId)
        {
            throw new NotImplementedException();
        }

        public bool orderNow(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
