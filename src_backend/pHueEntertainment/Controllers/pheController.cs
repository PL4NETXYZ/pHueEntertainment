using Microsoft.AspNetCore.Mvc;

namespace pHueEntertainment.Controllers
{
    public class pheController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
