using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWASMnet6BasicFilm.Server.Controllers
{
    [Route("apitest/[controller]")]
    [ApiController]

    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }




        [HttpGet]
        public async Task<ActionResult> DoThis()
        {
            return Ok("called");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> DoSingleTask()
        {
            return Ok("single called");
        }

    }
}
