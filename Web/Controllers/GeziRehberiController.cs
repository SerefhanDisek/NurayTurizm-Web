using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public IActionResult Videolar()
        {
            var videos = new List<Video>
            {
                new Video { Id = 1, Title = "Video 1", Description = "Bu, seyahatlerimizden bir videodur.", VideoUrl = "/videos/video1.mp4" },
                new Video { Id = 2, Title = "Video 2", Description = "Bu, seyahatlerimizden bir videodur.", VideoUrl = "/videos/video2.mp4" },
                new Video { Id = 3, Title = "Video 3", Description = "Bu, seyahatlerimizden bir videodur.", VideoUrl = "/videos/video3.mp4" }
            };

            return View(videos);
        }

        public IActionResult Haritalar()
        {
            return View();
        }

        public IActionResult Kameramizdan()
        {
            var cameras = new List<Camera>
            {
                new Camera { Id = 1, Title = "Kamera 1", Description = "Bu, seyahatlerimizden bir görüntüdür.", ImageUrl = "/img/camera1.jpg" },
                new Camera { Id = 2, Title = "Kamera 2", Description = "Bu, seyahatlerimizden bir görüntüdür.", ImageUrl = "/img/camera2.jpg" },
                new Camera { Id = 3, Title = "Kamera 3", Description = "Bu, seyahatlerimizden bir görüntüdür.", ImageUrl = "/img/camera3.jpg" }
            };

            return View(cameras);
        }
    }
}

