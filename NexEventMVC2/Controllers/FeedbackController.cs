using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
