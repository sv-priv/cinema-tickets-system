using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public ICollection<Ticket> TicketsInShoppingCart { get; set; }
    }
}
