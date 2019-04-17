using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class Status : EntityBase<int>
    {
        public string StatusName { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
