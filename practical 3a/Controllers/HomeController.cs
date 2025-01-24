/* 
PRACTICAL 3:- Develop ASP.NET Core MVC application which greets the user with “Good Morning!”, “Good Afternoon!”, or “Good Evening” based on the current time. Use Index.cshtml file to display greeting messages with appropriate image.
 
Enrollment No.:- 202203103510223

Branch:- B.Tech (CSE)
 */

using Microsoft.AspNetCore.Mvc;
using System;
namespace GreetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string greeting = GetGreeting();
            ViewData["Greeting"] = greeting;

            var hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                ViewData["Image"] = "morning.png";
            }
            else if (hour < 18)
            {
                ViewData["Image"] = "afternoon.png";
            }
            else
            {
                ViewData["Image"] = "evening.png";
            }

            return View();
        }

        private string GetGreeting()
        {
            var hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                return "Good Morning! AMTICS";
            }
            else if (hour < 18)
            {
                return "Good Afternoon! AMTICS";
            }
            else
            {
                return "Good Evening! AMTICS";
            }
        }
    }
}