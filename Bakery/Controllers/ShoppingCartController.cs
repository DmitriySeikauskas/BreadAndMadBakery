using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
