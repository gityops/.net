using Microsoft.AspNetCore.Mvc;

namespace practical13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Using ViewData
            ViewData["Message"] = "This message is from ViewData.";

            // Using ViewBag
            ViewBag.Message = "This message is from ViewBag.";

            // Using TempData
            TempData["Message"] = "This message is from TempData.";
            
            return View();
        }

        public IActionResult About()
        {
            // Accessing TempData
            ViewBag.TempDataMessage = TempData["Message"];
            return View();
        }
    }
}
