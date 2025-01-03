using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
