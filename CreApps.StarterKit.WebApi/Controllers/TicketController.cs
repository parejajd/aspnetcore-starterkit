using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreApps.StarterKit.Web.Controllers
{
    [Route("[controller]")]
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [Route("Get")]
        [ProducesResponseType(typeof(List<Ticket>),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            var allTickets = await _ticketService.GetAll(true);
            foreach (var ticket in allTickets)
            {
                ticket.Type.Tickets = null;
                ticket.Status.Tickets = null;
                ticket.Priority.Tickets = null;
            }
            return Ok(allTickets);
        }
    }
}