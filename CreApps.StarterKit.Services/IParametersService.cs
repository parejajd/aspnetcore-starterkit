using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CreApps.StarterKit.Models;

namespace CreApps.StarterKit.Services
{
    public interface IParametersService
    {
        Task<List<Priority>> GetPriorityList();
        Task<List<Status>> GetStatusList();
        Task<List<TicketType>> GetTicketTypeList();
    }
}
