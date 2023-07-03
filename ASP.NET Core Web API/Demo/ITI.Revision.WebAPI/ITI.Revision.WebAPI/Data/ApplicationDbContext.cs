using ITI.Revision.WebAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITI.Revision.WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext  //:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; } 

    }
}
