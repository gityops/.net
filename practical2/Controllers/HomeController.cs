/* PRACTICAL 2:-  Develop ASP.NET Core MVC application with HomeController.cs file and  
add following method in HomeController.cs file:
public ViewResult Index( )
{ return View(“MyView”); }
• Display information about your college in “MyView”.

Enrollment No.:- 202203103510223

Branch:- B.Tech (CSE) 
*/

using Microsoft.AspNetCore.Mvc;

namespace practical2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
    }
}