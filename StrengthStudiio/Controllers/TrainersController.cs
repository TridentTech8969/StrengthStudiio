using Microsoft.AspNetCore.Mvc;

namespace StrengthStudiio.Controllers
{
    public class TrainersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
