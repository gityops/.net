using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.CompilerServices;

namespace practical_3.Controllers
{
    public class HomeController : Controller
    {
// Index Action Method

        public IActionResult Index()
        {
            string greeting = GetGreeting();
            ViewData["Greeting"] = greeting;
            return View();
        }
// ---------------------------------------------------------
        private string GetGreeting()
        {
            var hour = DateTime.Now.Hour;
            return hour < 12 ? "Good Morning! AMTICS" :
                   hour < 18 ? "Good Afternoon! AMTICS" : "Good Evening AMTICS!";
                //    Nested Conditional Operators is used here 
        }
    }
}



        // private string GetGreeting()
//         {
//             var hour = DateTime.Now.Hour;
//             if (hour < 12)
//             {
//                 return "Good Morning!";
//             }
//             else if (hour < 18)
//             {
//                 return "Good Afternoon!";
//             }
//             else
//             {
//                 return "Good Evening!";
//             }
//         }
//     }
// }
