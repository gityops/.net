using Microsoft.AspNetCore.Mvc;
using practical10.Services;

namespace practical10.Controllers
{
    public class HomeController : Controller
    {
        private readonly CacheService _cacheService;

        public HomeController(CacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCachedTime()
        {
            var cachedTime = _cacheService.GetCachedData();
            ViewBag.CachedTime = cachedTime;
            return View();
        }

        [ResponseCache(Duration = 60)]
        public IActionResult CachedPage()
        {
            ViewBag.Message = "This is a cached page.";
            return View();
        }

        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult NoCachePage()
        {
            ViewBag.Message = "This page is not cached.";
            return View();
        }
    }
}
