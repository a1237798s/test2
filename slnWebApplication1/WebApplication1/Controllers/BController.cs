using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
