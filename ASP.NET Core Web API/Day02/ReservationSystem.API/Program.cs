
using Microsoft.EntityFrameworkCore;
using ReservationSystem.BL.Managers.Departments;
using ReservationSystem.BL.Managers.Tickets;
using ReservationSystem.DAL.Data.Context;
using ReservationSystem.DAL.Repos.Departments;
using ReservationSystem.DAL.Repos.Developers;
using ReservationSystem.DAL.Repos.Tickets;

namespace ReservationSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //ConnectionString
            var connectionString = builder.Configuration.GetConnectionString("MyCustomCon");
            builder.Services.AddDbContext<ReservationContext>(options
                => options.UseSqlServer(connectionString));


            #region Repos

            builder.Services.AddScoped<ITicketsRepo, TicketsRepo>();
            builder.Services.AddScoped<IDepartmentsRepo, DepartmentsRepo>();
            builder.Services.AddScoped<IDevelopersRepo, DevelopersRepo>();



            #endregion

            #region Managers

            builder.Services.AddScoped<ITicketsManager, TicketsManager>();
            builder.Services.AddScoped<IDepartmentsManager, DepartmentsManager>();



            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}