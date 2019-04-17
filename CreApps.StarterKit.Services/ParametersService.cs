using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CreApps.StarterKit.DataAccess;
using CreApps.StarterKit.Models;
using Microsoft.EntityFrameworkCore;

namespace CreApps.StarterKit.Services
{
    public class ParametersService : IParametersService
    {

        private readonly IRepository<Priority, int> _priorityRepository;
        private readonly IRepository<Status, int> _statusRepository;
        private readonly IRepository<TicketType, int> _ticketTypeRepository;

        public ParametersService(IRepository<Priority, int> priorityRepository,
                                IRepository<Status, int> statusRepository,
                                IRepository<TicketType, int> ticketTypeRepository)
        {
            _priorityRepository = priorityRepository;
            _statusRepository = statusRepository;
            _ticketTypeRepository = ticketTypeRepository;
        }

        public async Task<List<Priority>> GetPriorityList()
        {
            return await _priorityRepository.Query().ToListAsync();
        }

        public async Task<List<Status>> GetStatusList()
        {
            return await _statusRepository.Query().ToListAsync(); throw new NotImplementedException();
        }

        public async Task<List<TicketType>> GetTicketTypeList()
        {
            return await _ticketTypeRepository.Query().ToListAsync();
        }
    }
}
