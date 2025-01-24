using Microsoft.AspNetCore.Mvc;
using practical14.Models;
using System.Collections.Generic;

namespace practical14.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            // Implicit validation
            if (ModelState.IsValid)
            {
                // Explicit validation
                if (person.IsValid(out List<string> validationErrors))
                {
                    ViewBag.Message = "Person is valid.";
                }
                else
                {
                    foreach (var error in validationErrors)
                    {
                        ModelState.AddModelError(string.Empty, error);
                    }
                }
            }
            return View(person);
        }
    }
}
