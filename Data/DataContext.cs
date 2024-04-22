using Microsoft.EntityFrameworkCore;
using SuperheroApi_Dotnet8.Controllers.Entities;

namespace SuperheroApi_Dotnet8.Data
{
    public class DataContext : DbContext
    {
        // Boiler plate code
        // run base construction with options
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        // Add database set
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
