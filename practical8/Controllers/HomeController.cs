using Microsoft.AspNetCore.Mvc;
using practical8.Services;
using System.Threading.Tasks;

namespace practical8.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebDownloadService _webDownloadService;

        public HomeController(WebDownloadService webDownloadService)
        {
            _webDownloadService = webDownloadService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Download(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                ViewBag.Error = "Please provide a valid URL.";
                return View("Index");
            }

            try
            {
                var content = await _webDownloadService.DownloadStringAsync(url);
                ViewBag.Content = content;
            }
            catch (HttpRequestException e)
            {
                ViewBag.Error = $"Error downloading content: {e.Message}";
            }

            return View("Index");
        }
    }
}
