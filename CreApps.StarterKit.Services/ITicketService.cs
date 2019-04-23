using CreApps.StarterKit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CreApps.StarterKit.Services
{
    public interface ITicketService
    {
        Task Create(Ticket ticket);
        Task Update(Ticket ticket);
        Task Delete(int ticketId);
        Task<IList<Ticket>> GetAll();
        Task<Ticket> GetById(int id);
    }
}
