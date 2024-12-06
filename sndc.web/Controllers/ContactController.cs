using Microsoft.AspNetCore.Mvc;

namespace sndc.web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
