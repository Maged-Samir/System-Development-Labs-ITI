using Microsoft.EntityFrameworkCore;
using SharedLibrary;

namespace WebApiService.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Trainee> Trainees { get; set; }

        public virtual DbSet<Track> Tracks { get; set; }

    }
}
