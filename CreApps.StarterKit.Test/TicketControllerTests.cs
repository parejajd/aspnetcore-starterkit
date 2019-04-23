using CreApps.StarterKit.Models;
using CreApps.StarterKit.Services;
using CreApps.StarterKit.Test.DataClass;
using CreApps.StarterKit.Web.Controllers;
using CreApps.StarterKit.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CreApps.StarterKit.Test
{
    public class TicketControllerTests
    {
        Mock<ITicketService> _ticketService;
        Mock<IParametersService> _parameterService;

        public TicketControllerTests()
        {
            _ticketService = new Mock<ITicketService>();
            _ticketService.Setup(x => x.GetAll()).Returns(GetTickets());

            _parameterService = new Mock<IParametersService>();
            _parameterService.Setup(x => x.GetPriorityList()).Returns(GetPriorities());
            _parameterService.Setup(x => x.GetStatusList()).Returns(GetStatuses());
            _parameterService.Setup(x => x.GetTicketTypeList()).Returns(GetTicketsTypeList());
        }

        private async Task<List<TicketType>> GetTicketsTypeList()
        {
            return await Task.FromResult(new List<TicketType> { new TicketType
                {
                    Id = 1,
                    TicketTypeName = "Problem"
                },
                new TicketType
                {
                    Id = 2,
                    TicketTypeName = "Incident"
                },
                new TicketType
                {
                    Id = 3,
                    TicketTypeName = "New Requirement"
                }});
        }

        private async Task<List<Status>> GetStatuses()
        {
            return await Task.FromResult(new List<Status> { new Status
                {
                    Id = 1,
                    StatusName = "Pending"
                },
                new Status
                {
                    Id = 2,
                    StatusName = "In progress"
                },
                new Status
                {
                    Id = 3,
                    StatusName = "Resolved"
                },
                new Status
                {
                    Id = 4,
                    StatusName = "Closed"
                },
                new Status
                {
                    Id = 5,
                    StatusName = "Discarted"
                }});
        }

        private async Task<List<Priority>> GetPriorities()
        {
            return await Task.FromResult(new List<Priority> { new Priority
                {
                    Id = 1,
                    PriorityName = "Critical"
                },
                new Priority
                {
                    Id = 2,
                    PriorityName = "Urgent"
                },
                new Priority
                {
                    Id = 3,
                    PriorityName = "Medium"
                },
                new Priority
                {
                    Id = 4,
                    PriorityName = "Low"
                }});
        }

        private async Task<IList<Ticket>> GetTickets()
        {
            return await Task.FromResult(new List<Ticket> {
                new Ticket
                {
                    Id = 1,
                    Subject = "Create DB",
                    Description = "I need create a bd to save tickets",
                    PriorityId = 1,
                    StatusId = 1,
                    TypeId = 1
                }
            });
        }



        [Fact]
        public void Index_Will_Be_Return_IActionResult()
        {
            var ticketController = new TicketController(_ticketService.Object, _parameterService.Object);
            var result = ticketController.Index();
            var viewResult = Assert.IsType<ViewResult>(result.Result);
            Assert.IsAssignableFrom<IList<Ticket>>(viewResult.Model);
        }

        [Fact]
        public void Index_Will_Be_Return_Elements()
        {
            var ticketController = new TicketController(_ticketService.Object, _parameterService.Object);
            var result = ticketController.Index();
            var viewResult = Assert.IsType<ViewResult>(result.Result);
            var model = Assert.IsAssignableFrom<IList<Ticket>>(viewResult.Model);
            Assert.NotEmpty(model);
        }

        [Fact]
        public void Create_Get_Will_Be_Return_IActionResult()
        {
            var ticketController = new TicketController(_ticketService.Object, _parameterService.Object);
            var result = ticketController.Create();
            var viewResult = Assert.IsType<ViewResult>(result.Result);
            var model = Assert.IsAssignableFrom<TicketParametersViewModel>(viewResult.Model);
            Assert.NotEmpty(model.PriorityList);
            Assert.NotEmpty(model.StatusList);
            Assert.NotEmpty(model.TicketTypeList);
        }

        [Theory]
        [ClassData(typeof(TicketFailingTheoryData))]
        public void Create_Post_Will_Be_Fail_On_Model_Error(Ticket ticketNull, Ticket ticketEmpty, Ticket ticketDuplicate)
        {
            var ticketController = new TicketController(_ticketService.Object, _parameterService.Object);
            var resultOnNull = ticketController.Create(ticketNull);
            Assert.IsType<BadRequestObjectResult>(resultOnNull.Result); //Valida datos NULOS

            var resultOnEmpty = ticketController.Create(ticketEmpty);
            Assert.IsType<BadRequestObjectResult>(resultOnEmpty.Result); //Valida datos vacios

            var resultOnDuplicate = ticketController.Create(ticketDuplicate);
            Assert.IsType<BadRequestObjectResult>(resultOnDuplicate.Result); //Valida datos REPETIDOS
        }
    }
}
