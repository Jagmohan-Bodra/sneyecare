using Microsoft.AspNetCore.Mvc;

namespace sndc.web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
