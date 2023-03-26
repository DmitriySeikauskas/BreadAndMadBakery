using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
