using Microsoft.AspNetCore.Mvc;

namespace sndc.web.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
