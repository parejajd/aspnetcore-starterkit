using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CreApps.StarterKit.Models
{
    public class Ticket : EntityBase<int>
    {
        [Required(AllowEmptyStrings = false)]
        public string Subject { get; set; }
        public int TypeId { get; set; }
        public TicketType Type { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
    }
}
