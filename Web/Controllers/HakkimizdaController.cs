using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ilkelerimiz()
        {
            return View();
        }
    }
}
