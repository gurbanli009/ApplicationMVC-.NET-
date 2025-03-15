using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
