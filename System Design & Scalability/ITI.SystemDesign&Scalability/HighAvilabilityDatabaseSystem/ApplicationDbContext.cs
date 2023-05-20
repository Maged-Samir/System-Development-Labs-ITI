using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HighAvilabilityDatabaseSystem
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WeatherForecast> weatherForecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PrimaryConnection"));
            // Or use SecondaryConnection for the secondary server
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings
        }

    }
}
