using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
