using Microsoft.AspNetCore.Mvc;

namespace sndc.web.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
