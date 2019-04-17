using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class TicketType : EntityBase<int>
    {
        public string TicketTypeName { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
