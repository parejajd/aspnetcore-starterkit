using CreApps.StarterKit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CreApps.StarterKit.Test.DataClass
{
    public class TicketFailingTheoryData : TheoryData<Ticket, Ticket, Ticket>
    {
        public TicketFailingTheoryData()
        {
            Add(null,
                new Ticket(),
                new Ticket
                {
                    Id = 1,
                    Subject = "Create DB",
                    Description = "I need create a bd to save tickets",
                    PriorityId = 1,
                    StatusId = 1,
                    TypeId = 1
                });
        }
    }

    public class TicketSuccessTheoryData : TheoryData<Ticket, Ticket, Ticket>
    {
        public TicketSuccessTheoryData()
        {
            Add(new Ticket
                {
                    Id = 2,
                    Subject = "Create a Repository",
                    Description = "Create a Repository",
                    PriorityId = 1,
                    StatusId = 2,
                    TypeId = 3
                }, 
                new Ticket
                {
                    Id = 3,
                    Subject = "Create a Service",
                    Description = "Create a Service",
                    PriorityId = 1,
                    StatusId = 2,
                    TypeId = 3
                },
                new Ticket
                {
                    Id = 4,
                    Subject = "Create a Controller",
                    Description = "Create a Controller",
                    PriorityId = 1,
                    StatusId = 2,
                    TypeId = 3
                });
        }
    }
}
