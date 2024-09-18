using Microsoft.AspNetCore.Mvc;

namespace JojoFinancasApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
