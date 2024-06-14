using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class GeziRehberiController : Controller
    {
        public IActionResult Fotograflar()
        {
            // Örnek fotoğraf verileri
            var photos = new List<Photo>
            {
                new Photo { Id = 1, Title = "Fotoğraf 1", Description = "Bu, seyahatlerimizden bir fotoğraftır.", ImageUrl = "/img/photo1.jpg" },
                new Photo { Id = 2, Title = "Fotoğraf 2", Description = "Bu, seyahatlerimizden bir fotoğraftır.", ImageUrl = "/img/photo2.jpg" },
                new Photo { Id = 3, Title = "Fotoğraf 3", Description = "Bu, seyahatlerimizden bir fotoğraftır.", ImageUrl = "/img/photo3.jpg" }
            };

            return View(photos);
        }
    }
}

