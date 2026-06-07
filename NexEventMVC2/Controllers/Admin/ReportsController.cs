using Microsoft.AspNetCore.Mvc;

namespace NexEventMVC2.Controllers.Admin
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
