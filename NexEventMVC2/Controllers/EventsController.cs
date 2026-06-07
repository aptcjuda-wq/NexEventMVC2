using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
