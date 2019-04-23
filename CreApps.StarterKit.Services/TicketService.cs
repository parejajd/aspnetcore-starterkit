using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CreApps.StarterKit.Services
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket, int> _ticketRepository;

        public TicketService(IRepository<Ticket, int> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<IList<Ticket>> GetAll()
        {
            var tickets = await _ticketRepository.Query()
                                .Include(x => x.Type)
                                .Include(x => x.Status)
                                .Include(x => x.Priority)
                                .ToListAsync();

            return tickets;
        }

        public async Task Create(Ticket ticket)
        {
            _ticketRepository.Add(ticket);
            await _ticketRepository.SaveChangeAsync();
        }

        public async Task Delete(int ticketId)
        {
            var ticket = await _ticketRepository.Query()
                            .FirstOrDefaultAsync(x => x.Id == ticketId);

            _ticketRepository.Remove(ticket);
            await _ticketRepository.SaveChangeAsync();
        }

        public async Task Update(Ticket ticket)
        {
            var oldTicket = await _ticketRepository.Query()
                            .FirstOrDefaultAsync(x => x.Id == ticket.Id);

            oldTicket.Subject = ticket.Subject;
            oldTicket.PriorityId = ticket.PriorityId;
            oldTicket.StatusId = ticket.StatusId;
            oldTicket.TypeId = ticket.TypeId;
            oldTicket.Description = ticket.Description;
            oldTicket.UpdatedOn = DateTime.Now;

            await _ticketRepository.SaveChangeAsync();
        }

        public async Task<Ticket> GetById(int id)
        {
            return await _ticketRepository.Query()
                          .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
