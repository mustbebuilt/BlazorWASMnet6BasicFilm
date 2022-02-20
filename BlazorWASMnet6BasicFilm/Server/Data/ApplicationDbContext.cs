namespace BlazorWASMnet6BasicFilm.Server.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
    }
}
