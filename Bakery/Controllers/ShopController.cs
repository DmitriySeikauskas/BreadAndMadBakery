using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
