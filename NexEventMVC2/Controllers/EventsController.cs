using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NexEventMVC2.Data;
using NexEventMVC2.Models;

namespace NexEventMVC2.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var events = await _context.Events
                .OrderByDescending(e => e.Date)
                .ToListAsync();

            return View(events);
        }
        public async Task<IActionResult> Details(int id)
        {
            var evt = await _context.Events
                .FirstOrDefaultAsync(e => e.Id == id);

            if (evt == null)
                return NotFound();

            return View(evt);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event model)
        {
            if (string.IsNullOrEmpty(model.Status))
                model.Status = "Published";

            if (string.IsNullOrEmpty(model.Category))
                model.Category = "Conference";

            _context.Events.Add(model);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await _context.Events.FindAsync(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Event model)
        {
            if (id != model.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(model);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var evt = await _context.Events.FindAsync(id);

            if (evt == null)
                return NotFound();

            return View(evt);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var evt = await _context.Events.FindAsync(id);

            if (evt != null)
            {
                _context.Events.Remove(evt);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }

}

