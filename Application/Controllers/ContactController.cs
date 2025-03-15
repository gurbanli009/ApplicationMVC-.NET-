using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
