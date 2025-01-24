/* 
PRACTICAL 4: Create ASP.NET Core MVC project with two view files Index.cshtml and Welcome.cshtml. Add a link in Index.cshtml file with “asp-action” attribute to navigate to Welcome.cshtml.
 
Enrollment No.:- 202203103510223

Branch:- B.Tech (CSE)
*/

using Microsoft.AspNetCore.Mvc;

namespace practical4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
