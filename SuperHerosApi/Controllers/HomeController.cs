using Microsoft.AspNetCore.Mvc;

namespace SuperHerosApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
