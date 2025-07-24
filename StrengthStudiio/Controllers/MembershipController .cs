using Microsoft.AspNetCore.Mvc;

namespace StrengthStudiio.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
