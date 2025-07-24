using Microsoft.AspNetCore.Mvc;

namespace StrengthStudiio.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
