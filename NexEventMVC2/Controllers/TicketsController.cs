using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers
{
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
            return View();
        }
    }
}
