using Microsoft.AspNetCore.Mvc;

namespace Voorbeeld1.Controllers
{
    public class WebShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registreer()
        {
            return View();
        }

        public IActionResult WinkelMandje()
        {
            return View();
        }
    }
}
