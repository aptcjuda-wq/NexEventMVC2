using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NexEventMVC2.Data;
using NexEventMVC2.Models;

namespace NexEventMVC2.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public TicketsController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> MyTickets()
        {
            var tickets = await _context.Registrations
                .Include(r => r.Event)
                .ToListAsync();

            return View(tickets);
        }
        public async Task<IActionResult> BookTicket(int id)
        {
            var evt = await _context.Events
                .FirstOrDefaultAsync(e => e.Id == id);

            if (evt == null)
                return NotFound();

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return Challenge();
            }

            var registration = new Registration
            {
                EventId = evt.Id,
                UserId = user.Id,
                TicketQuantity = 1,
                TotalAmount = evt.TicketPrice,
                Status = "Active",
                CreatedDate = DateTime.Now
            };

            _context.Registrations.Add(registration);

            await _context.SaveChangesAsync();

            TempData["Success"] = "Ticket booked successfully.";

            return RedirectToAction("MyTickets");
        }
        public async Task<IActionResult> CancelTicket(int id)
        {
            var ticket = await _context.Registrations
                .FirstOrDefaultAsync(r => r.Id == id);

            if (ticket == null)
                return NotFound();

            ticket.Status = "Cancelled";

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(MyTickets));
        }

    }
}