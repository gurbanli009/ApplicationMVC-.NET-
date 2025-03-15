using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
