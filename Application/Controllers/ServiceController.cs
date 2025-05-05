using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
