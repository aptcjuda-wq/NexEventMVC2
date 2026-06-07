using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers.Admin
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
