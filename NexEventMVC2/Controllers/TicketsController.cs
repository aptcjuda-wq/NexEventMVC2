using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
