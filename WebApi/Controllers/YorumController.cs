using Business;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YorumController : ControllerBase
    {
        private readonly YorumService _yorumService;

        public YorumController(YorumService yorumService)
        {
            _yorumService = yorumService;
        }

        [HttpGet]
        public IEnumerable<Yorum> GetYorumlar()
        {
            return _yorumService.GetYorumlar();
        }

        [HttpGet("{id}")]
        public ActionResult<Yorum> GetYorum(int id)
        {
            var yorum = _yorumService.GetYorumById(id);
            if (yorum == null)
            {
                return NotFound();
            }

            return yorum;
        }

        [HttpPost]
        public IActionResult CreateYorum(Yorum yorum)
        {
            _yorumService.CreateYorum(yorum);
            return CreatedAtAction(nameof(GetYorum), new { id = yorum.ID }, yorum);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateYorum(int id, Yorum yorum)
        {
            if (id != yorum.ID)
            {
                return BadRequest();
            }

            _yorumService.UpdateYorum(yorum);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteYorum(int id)
        {
            _yorumService.DeleteYorum(id);
            return NoContent();
        }
    }
}

