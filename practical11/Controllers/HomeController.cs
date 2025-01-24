using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practical11.Data;
using System.Threading.Tasks;

namespace practical11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.Category).Include(p => p.Supplier).ToListAsync();
            return View(products);
        }
    }
}
