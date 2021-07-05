using Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Identity
{

    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ShoppingCart UserCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
