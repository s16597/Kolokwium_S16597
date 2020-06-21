using System.Linq;
using Kolokwium.Models;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api/musicians")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly IMusicDbService _dbService;
        public MusicianController(IMusicDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(string id)
        {
            var _musician = _dbService.GetMusician(id);
            if (_musician.Any())
                return Ok(_dbService.GetMusician(id));
            else
                return NotFound("Muzyka o podanym numerze Id nie ma w bazie");
        }

        [HttpPost]
        public IActionResult AddMusician(Musician musician)
        {
            var mus = _dbService.AddMusician(musician);
            if (mus == null)
            {
                return BadRequest("Wprowadź poprawne i kompletne dane muzyka");
            }
            else
            {
                return Ok(mus);
            }
        }
    }
}
