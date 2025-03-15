using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class NewCarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
