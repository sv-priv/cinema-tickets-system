using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainModels
{
    public class EmailMessage : BaseEntity
    {
        public String MailTo { get; set; }
        public String Subject { get; set; }
        public String Content { get; set; }
        public Boolean Status { get; set; }
    }
}
