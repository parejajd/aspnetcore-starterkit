using CreApps.StarterKit.DataAccess;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.Services;
using CreApps.StarterKit.Test.Web.DataAccess;
using CreApps.StarterKit.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CreApps.StarterKit.Test.Web.Web.Controllers
{
    public class PriorityControllerTests
    {
        readonly Mock<IParametersService> parameterService;

        public PriorityControllerTests()
        {
            parameterService = new Mock<IParametersService>();
        }

        [Fact]
        public void Index_Return_IActionResult()
        {
            //Arrange (Preparar)
            var priorityController = new PriorityController(parameterService.Object);
            //Act (Actuar)
            var actionResult = priorityController.Index();
            //Assert (Verificar)
            Assert.IsType<ViewResult>(actionResult.Result);
        }
        
        [Fact]
        public void Index_Return_Priority_List()
        {
            //Arrange (Preparar)
            var priorityController = new PriorityController(parameterService.Object);
            parameterService.Setup(x => x.GetPriorityList()).Returns(GetPriorities());
            //Act (Actuar)
            var result = priorityController.Index();
            //Assert (Verificar)
            var viewResult = Assert.IsType<ViewResult>(result.Result);
            var viewModel = Assert.IsType<List<Priority>>(viewResult.Model);
            Assert.Equal(4, viewModel.Count);
        }

        [Fact]
        public async void Service_Return_Priority_List()
        {
            using (var context = new InMemoryDbContextFactory().GetDbContext())
            {
                var repositoryPriority = new Repository<Priority, int>(context);
                var repositoryStatus = new Repository<Status, int>(context);
                var repositoryTicketType = new Repository<TicketType, int>(context);

                var serviceParameters = new ParametersService(repositoryPriority, repositoryStatus, repositoryTicketType);

                var list = await serviceParameters.GetPriorityList();

                Assert.NotEmpty(list);
            }
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
    }
}
