using Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface ITicketService
    {
        List<Ticket> GetAllTickets();
        Ticket GetDetailsForTicket(Guid? id);

        void EditTicket(Ticket p);
        void DeleteTicket(Guid id);
        bool AddToShoppingCart(Ticket item, string userID);
        Ticket AddTicket(Ticket ticket);
    }
}
