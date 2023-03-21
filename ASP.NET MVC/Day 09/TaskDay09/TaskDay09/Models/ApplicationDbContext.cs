using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace TaskDay09.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Track> Tracks { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }



        public DbSet<Flight> Flights { get; set; }
        public DbSet<City> Cities { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


            builder.Entity<City>().HasMany(c=>c.Arriving)
                .WithOne(c=>c.Arrival).HasForeignKey(c=>c.ArrivalId).OnDelete(DeleteBehavior.Restrict);


            builder.Entity<City>().HasMany(c => c.Departing)
                .WithOne(c => c.Departure).HasForeignKey(c => c.DepartureId).OnDelete(DeleteBehavior.Restrict);



        }
    }
}
