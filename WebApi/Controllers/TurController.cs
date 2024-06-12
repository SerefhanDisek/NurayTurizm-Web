using Business;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurController : ControllerBase
    {
        private readonly TurService _turService;

        public TurController(TurService turService)
        {
            _turService = turService;
        }

        [HttpGet]
        public IEnumerable<Tur> GetTurlar()
        {
            return _turService.GetTurlar();
        }

        [HttpGet("{id}")]
        public ActionResult<Tur> GetTur(int id)
        {
            var tur = _turService.GetTurById(id);
            if (tur == null)
            {
                return NotFound();
            }

            return tur;
        }

        // Diğer API uç noktaları...
    }
}

