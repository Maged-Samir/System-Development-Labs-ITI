using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HighAvilabilityDatabaseSystem
{
    public class AvilabilityService
    {
        private readonly IConfiguration configuration;

        public AvilabilityService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void DoSomething()
        {
            var primaryConnection = configuration.GetConnectionString("PrimaryConnection");

            using (var dbContext = CreateDbContext(primaryConnection))
            {
                try
                {
                    // Perform database operations
                }
                catch (SqlException)
                {
                    // Switch to the secondary connection in case of primary server failure
                    var secondaryConnection = configuration.GetConnectionString("SecondaryConnection");
                    dbContext.Dispose(); // Dispose the existing DbContext
                    using (var secondaryDbContext = CreateDbContext(secondaryConnection))
                    {
                        // Perform database operations using the secondary connection
                    }

                    // Retry the operation
                    // ...
                }
            }
        }
        private ApplicationDbContext CreateDbContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
    
}
