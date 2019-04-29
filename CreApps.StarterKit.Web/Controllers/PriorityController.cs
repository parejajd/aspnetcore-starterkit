using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreApps.StarterKit.DataAccess;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreApps.StarterKit.Web.Controllers
{
    public class PriorityController : Controller
    {
        private readonly IParametersService parametersService;

        public PriorityController(IParametersService parametersService)
        {
            this.parametersService = parametersService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await parametersService.GetPriorityList();
            return View(model);
        }
    }
}