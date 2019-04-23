using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.Services;
using CreApps.StarterKit.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreApps.StarterKit.Web.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly IParametersService _parametersService;

        public TicketController(ITicketService ticketService, IParametersService parametersService)
        {
            _ticketService = ticketService;
            _parametersService = parametersService;
        }

        public async Task<IActionResult> Index(bool fullTree = true)
        {
            var allTickets = await _ticketService.GetAll(fullTree);

            return View(allTickets);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new TicketParametersViewModel
            {
                PriorityList = await _parametersService.GetPriorityList(),
                StatusList = await _parametersService.GetStatusList(),
                TicketTypeList = await _parametersService.GetTicketTypeList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ticket ticket)
        {
            if (ticket is null)
            {
                return BadRequest("El ticket no puede estar nulo");
            }
            else
            {
                if (ModelState.IsValid == false || ticket.IsValid() == false)
                {
                    return BadRequest("El ticket contiene datos erroneos");
                }
                else
                {
                    var existingTicket = await this._ticketService.GetById(ticket.Id);
                    if (existingTicket != null)
                    {
                        return BadRequest("El ticket especificado ya existe");
                    }
                }
            }

            await _ticketService.Create(ticket);
            return RedirectToAction("Index");
        }
    }
}