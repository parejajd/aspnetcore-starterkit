using CreApps.StarterKit.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreApps.StarterKit.Web.Models
{
    public class TicketParametersViewModel
    {
        public List<Status> StatusList { get; set; }
        public List<Priority> PriorityList { get; set; }
        public List<TicketType> TicketTypeList { get; set; }

        public List<SelectListItem> StatusSelecteListItem
        {
            get
            {
                return StatusList?.Select(x => new SelectListItem { Value = x.Id + "", Text = x.StatusName }).ToList() ?? 
                                        new List<SelectListItem>();
            }
        }

        public List<SelectListItem> PrioritySelecteListItem
        {
            get
            {
                return PriorityList?.Select(x => new SelectListItem { Value = x.Id + "", Text = x.PriorityName }).ToList() ??
                                        new List<SelectListItem>();
            }
        }

        public List<SelectListItem> TicketTypeSelecteListItem
        {
            get
            {
                return TicketTypeList?.Select(x => new SelectListItem { Value = x.Id + "", Text = x.TicketTypeName }).ToList() ??
                                        new List<SelectListItem>();
            }
        }

        public Ticket Ticket { get; set; }
    }
}
