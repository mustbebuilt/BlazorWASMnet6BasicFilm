using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWASMnet6BasicFilm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FilmController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public FilmController(ApplicationDbContext context)
        {
            _context = context;
        }




        [HttpGet]
    public async Task<ActionResult<List<Film>>> GetFilms()
    {
        var allFilms = await _context.Films.ToListAsync();
        return Ok(allFilms);
    }

        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetSingleFilm(int id)
        {
            var film = await _context.Films
                .FirstOrDefaultAsync(f => f.FilmID == id);
            if (film == null)
            {
                return NotFound("Sorry, no film here. :/");
            }
            return Ok(film);
        }

    }
}
