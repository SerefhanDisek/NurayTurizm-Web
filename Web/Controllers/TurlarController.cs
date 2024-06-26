using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TurlarController : Controller
    {
        public IActionResult Uludag()
        {
            return View();
        }

        public IActionResult Karadeniz()
        {
            return View();
        }

        public IActionResult Pamukkale()
        {
            return View();
        }

        public IActionResult Kaplica()
        {
            return View();
        }

        public IActionResult Gap()
        {
            return View();
        }

        public IActionResult Gunubirlik()
        {
            return View();
        }

        public IActionResult EgeAkdeniz()
        {
            return View();
        }

        public IActionResult Istanbul()
        {
            return View();
        }

        public IActionResult Kapadokya()
        {
            return View();
        }

        public IActionResult Balkan()
        {
            return View();
        }

        public IActionResult Umre()
        {
            return View();
        }

        public IActionResult Italya()
        {
            return View();
        }

        public IActionResult EgeAdalari()
        {
            return View();
        }

        public IActionResult BatumGurcistan()
        {
            return View();
        }

        public IActionResult Azerbaycan()
        {
            return View();
        }

        public IActionResult Dubai()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Arama(string destination, DateTime? startDate, DateTime? endDate, int guests)
        {
            // Arama kriterlerine göre turları filtreleme ve yönlendirme işlemleri
            // Örneğin, destination'a göre ilgili tur sayfasına yönlendirme
            if (string.IsNullOrWhiteSpace(destination))
            {
                return RedirectToAction("Index");
            }

            switch (destination.ToLower())
            {
                case "uludağ":
                    return RedirectToAction("Uludag");
                case "karadeniz":
                    return RedirectToAction("Karadeniz");
                case "pamukkale":
                    return RedirectToAction("Pamukkale");
                case "kaplıca":
                    return RedirectToAction("Kaplica");
                case "gap":
                    return RedirectToAction("Gap");
                case "günübirlik":
                    return RedirectToAction("Gunubirlik");
                case "ege-akdeniz":
                    return RedirectToAction("EgeAkdeniz");
                case "istanbul":
                    return RedirectToAction("Istanbul");
                case "kapadokya":
                    return RedirectToAction("Kapadokya");
                case "balkan":
                    return RedirectToAction("Balkan");
                case "umre":
                    return RedirectToAction("Umre");
                case "italya":
                    return RedirectToAction("Italya");
                case "ege adaları":
                    return RedirectToAction("EgeAdalari");
                case "batum-gürcistan":
                    return RedirectToAction("BatumGurcistan");
                case "azerbaycan":
                    return RedirectToAction("Azerbaycan");
                case "dubai":
                    return RedirectToAction("Dubai");
                default:
                    return RedirectToAction("Index");
            }
        }
    }
}

