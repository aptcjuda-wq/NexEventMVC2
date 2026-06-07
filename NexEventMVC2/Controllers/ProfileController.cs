using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
