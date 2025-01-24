using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using practical6.Models;

namespace practical6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Manager { Id = 1, Name = "John Doe", Position = "Manager", Department = "Sales" },
                new Clerk { Id = 2, Name = "Jane Smith", Position = "Clerk", SupervisorName = "John Doe" }
            };

            return View(employees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
