using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class Priority : EntityBase<int>
    {
        public string PriorityName { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
