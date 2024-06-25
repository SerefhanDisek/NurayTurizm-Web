using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Web.Controllers
{
    public class AramaController : Controller
    {
        // Bu örnekte bir liste üzerinden arama yapıyoruz.
        private static List<string> ornekVeri = new List<string>
        {
            "Uludağ Turları",
            "Karadeniz Turları",
            "Pamukkale Turları",
            "Kapadokya Turları",
            "GAP Turları",
            "Günübirlik Turlar",
            "Ege-Akdeniz Turları",
            "İstanbul Turları",
            "Balkan Turları",
            "Umre Organizasyonları",
            "İtalya Turları",
            "Ege Adaları Turları",
            "Batum - Gürcistan Turları",
            "Azerbaycan Turları",
            "Dubai Turları"
        };

        [HttpGet]
        public IActionResult Index(string q)
        {
            var results = ornekVeri.Where(v => v.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
            return View(results);
        }
    }
}
