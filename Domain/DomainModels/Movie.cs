using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainModels
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public Ticket Ticket { get; set; }
    }
}
