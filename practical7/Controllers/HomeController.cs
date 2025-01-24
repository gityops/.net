using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using practical7.Models;
using practical7.Extensions;

namespace practical7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 60000 },
                new Employee { Id = 2, Name = "Jane Smith", Position = "Clerk", Salary = 35000 }
            };

            ViewBag.Bonuses = new Dictionary<int, decimal>();
            foreach (var employee in employees)
            {
                var bonus = employee.CalculateAnnualBonus(10); // 10% bonus
                ViewBag.Bonuses[employee.Id] = bonus;
            }

            return View(employees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
