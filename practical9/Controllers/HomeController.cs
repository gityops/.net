using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace practical9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetCookie()
        {
            // Set a cookie
            CookieOptions option = new CookieOptions();
            option.Expires = System.DateTime.Now.AddMinutes(30);
            Response.Cookies.Append("MyCookie", "Cookie Value", option);
            ViewBag.Message = "Cookie has been set.";
            return View("Index");
        }

        public IActionResult GetCookie()
        {
            // Get the cookie
            ViewBag.Message = Request.Cookies["MyCookie"] ?? "Cookie not found.";
            return View("Index");
        }

        public IActionResult SetSession()
        {
            // Set a session value
            HttpContext.Session.SetString("MySession", "Session Value");
            ViewBag.Message = "Session value has been set.";
            return View("Index");
        }

        public IActionResult GetSession()
        {
            // Get the session value
            ViewBag.Message = HttpContext.Session.GetString("MySession") ?? "Session value not found.";
            return View("Index");
        }

        public IActionResult QueryStringDemo(string value)
        {
            // Get the query string value
            ViewBag.Message = $"Query string value: {value}";
            return View("Index");
        }

        [HttpPost]
        public IActionResult HiddenFieldDemo(string hiddenFieldValue)
        {
            // Get the hidden field value
            ViewBag.Message = $"Hidden field value: {hiddenFieldValue}";
            return View("Index");
        }
    }
}
