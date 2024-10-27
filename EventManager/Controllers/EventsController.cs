using Microsoft.AspNetCore.Mvc;

namespace EventManager.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EventsHome()
        {
            return View();
        }

    }
}
