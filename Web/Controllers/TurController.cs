using Business;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TurController : Controller
    {
        private readonly TurService _turService;

        public TurController(TurService turService)
        {
            _turService = turService;
        }

        public IActionResult Index()
        {
            var turlar = _turService.GetTurlar();
            return View(turlar);
        }

        public IActionResult Details(int id)
        {
            var tur = _turService.GetTurById(id);
            if (tur == null)
            {
                return NotFound();
            }
            return View(tur);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tur tur)
        {
            if (ModelState.IsValid)
            {
                _turService.CreateTur(tur);
                return RedirectToAction(nameof(Index));
            }
            return View(tur);
        }

        public IActionResult Edit(int id)
        {
            var tur = _turService.GetTurById(id);
            if (tur == null)
            {
                return NotFound();
            }
            return View(tur);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Tur tur)
        {
            if (id != tur.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _turService.UpdateTur(tur);
                return RedirectToAction(nameof(Index));
            }
            return View(tur);
        }

        public IActionResult Delete(int id)
        {
            var tur = _turService.GetTurById(id);
            if (tur == null)
            {
                return NotFound();
            }
            return View(tur);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _turService.DeleteTur(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

