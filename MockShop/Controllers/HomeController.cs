using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MockShop.Models;

namespace MockShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopContext _shop;

        public HomeController(ILogger<HomeController> logger, ShopContext shop)
        {
            _logger = logger;
            _shop = shop;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _shop.Products.ToListAsync());
        }

        public IActionResult Privacy()
        {
            var orders = _shop.Orders.ToList();
            return View(orders);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}