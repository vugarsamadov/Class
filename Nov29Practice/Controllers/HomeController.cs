using Microsoft.AspNetCore.Mvc;
using Nov29Practice.Models;
using Nov29Practice.Services;
using System.Diagnostics;

namespace Nov29Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var data = await new EmployeeService().GetEmployees();
            return View(data);
        }

        public async Task<IActionResult> Tables()
        {
            var data = await new EmployeeService().GetEmployees();
            return View(data);
        }

   
    }
}