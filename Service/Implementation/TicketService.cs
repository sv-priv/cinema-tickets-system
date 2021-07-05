using Domain.DomainModels;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;
        private readonly IUserRepository _userRepository;


        public TicketService(IRepository<Ticket> ticketRepository,
                             IUserRepository userRepository,
                             IRepository<ShoppingCart> shoppingCartRepository)
        {
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public Ticket AddTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public bool AddToShoppingCart(Ticket item, string userID)
        {
            throw new NotImplementedException();
        }

        public void DeleteTicket(Guid id)
        {
            throw new NotImplementedException();
        }

        public void EditTicket(Ticket p)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public Ticket GetDetailsForTicket(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
