using EventManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> EventsHome(int id)
        {
            var events = await _context.Events.FirstOrDefaultAsync(x => x.Id == id);
            return View(events);
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
