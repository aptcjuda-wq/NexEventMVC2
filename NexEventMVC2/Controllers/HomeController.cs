using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NexEventMVC2.Data;

namespace NexEventMVC2.Controllers
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
            var eventsList = await _context.Events
                .Where(e => e.Status == "Published")
                .OrderByDescending(e => e.Date)
                .Take(12)
                .ToListAsync();

            return View(eventsList);
        }
    }
}