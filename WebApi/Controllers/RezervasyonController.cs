using Business;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervasyonController : ControllerBase
    {
        private readonly RezervasyonService _rezervasyonService;

        public RezervasyonController(RezervasyonService rezervasyonService)
        {
            _rezervasyonService = rezervasyonService;
        }

        [HttpGet]
        public IEnumerable<Rezervasyon> GetRezervasyonlar()
        {
            return _rezervasyonService.GetRezervasyonlar();
        }

        [HttpGet("{id}")]
        public ActionResult<Rezervasyon> GetRezervasyon(int id)
        {
            var rezervasyon = _rezervasyonService.GetRezervasyonById(id);
            if (rezervasyon == null)
            {
                return NotFound();
            }

            return rezervasyon;
        }

        [HttpPost]
        public IActionResult CreateRezervasyon(Rezervasyon rezervasyon)
        {
            _rezervasyonService.CreateRezervasyon(rezervasyon);
            return CreatedAtAction(nameof(GetRezervasyon), new { id = rezervasyon.ID }, rezervasyon);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRezervasyon(int id, Rezervasyon rezervasyon)
        {
            if (id != rezervasyon.ID)
            {
                return BadRequest();
            }

            _rezervasyonService.UpdateRezervasyon(rezervasyon);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRezervasyon(int id)
        {
            _rezervasyonService.DeleteRezervasyon(id);
            return NoContent();
        }
    }
}

