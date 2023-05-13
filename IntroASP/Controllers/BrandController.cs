using Microsoft.AspNetCore.Mvc;

namespace IntroASP.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
