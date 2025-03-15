using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class FeaturedCarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
