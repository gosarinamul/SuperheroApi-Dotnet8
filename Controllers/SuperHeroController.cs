using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperheroApi_Dotnet8.Controllers.Entities;
using SuperheroApi_Dotnet8.Data;

namespace SuperheroApi_Dotnet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        // Inject DataContext
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            // DB set of SuperHeroes
            var heroes = await _context.SuperHeroes.ToListAsync();
            return Ok(heroes);
        
        }

    }
}
