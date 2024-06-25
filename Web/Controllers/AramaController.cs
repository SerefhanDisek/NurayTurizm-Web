using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    public class AramaController : Controller
    {
        // Örnek veri listesi ve ilgili pathler
        private static readonly Dictionary<string, string> ornekVeri = new Dictionary<string, string>
        {
            { "Uludağ Turları", "/Turlar/Uludag" },
            { "Karadeniz Turları", "/Turlar/Karadeniz" },
            { "Pamukkale Turları", "/Turlar/Pamukkale" },
            { "Kapadokya Turları", "/Turlar/Kapadokya" },
            { "GAP Turları", "/Turlar/Gap" },
            { "Günübirlik Turlar", "/Turlar/Gunubirlik" },
            { "Ege-Akdeniz Turları", "/Turlar/EgeAkdeniz" },
            { "İstanbul Turları", "/Turlar/Istanbul" },
            { "Balkan Turları", "/Turlar/Balkan" },
            { "Umre Organizasyonları", "/Turlar/Umre" },
            { "İtalya Turları", "/Turlar/Italya" },
            { "Ege Adaları Turları", "/Turlar/EgeAdalari" },
            { "Batum - Gürcistan Turları", "/Turlar/BatumGurcistan" },
            { "Azerbaycan Turları", "/Turlar/Azerbaycan" },
            { "Dubai Turları", "/Turlar/Dubai" }
        };

        [HttpGet]
        public IActionResult Index(string q)
        {
            var results = ornekVeri
                .Where(v => v.Key.Contains(q, System.StringComparison.OrdinalIgnoreCase))
                .ToList();

            return View(results);
        }
    }
}
