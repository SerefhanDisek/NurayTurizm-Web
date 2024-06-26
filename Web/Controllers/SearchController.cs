using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Results(string destination, string checkin, string checkout, int guests, string query)
        {
            // Arama kriterlerine göre sonuçları burada işleyin
            // Örneğin, veritabanından ilgili sonuçları çekin
            var searchResults = new List<string>(); // Örnek veri, gerçek veritabanı sorgusu ile değiştirilmelidir

            // Örnek veri
            if (!string.IsNullOrEmpty(query))
            {
                searchResults.Add($"Sonuç: {query}");
            }
            else
            {
                searchResults.Add($"Sonuç: {destination}, {checkin}, {checkout}, {guests} Misafir");
            }

            return View(searchResults);
        }
    }
}
