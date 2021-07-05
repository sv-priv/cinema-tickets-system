using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        public Movie Movie { get; set; }
        public string Hall { get; set; }
        public int Seat { get; set; }
        public double Price { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public Order Order { get; set; }
        public bool Availability { get; set; }
        public DateTime DateTime { get; set; }
    }
}
