using EventManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManager.Models; // So the computer knows what its using

namespace EventManager.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> EventsHome()
        {
            var events = await _context.Events.ToListAsync();
            return View(events);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //Tells the computer we are sending data not retreving
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Date")] Events e)
        {

            if (ModelState.IsValid)
            {
                
                _context.Add(e);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return View(e);
            
        }

    }
}
