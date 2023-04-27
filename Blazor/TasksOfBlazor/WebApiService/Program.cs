
using Microsoft.EntityFrameworkCore;
using WebApiService.Model;

namespace WebApiService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<ApplicationDbContext>(op =>
                op.UseSqlServer("Data Source=.;Initial Catalog=ApiDB_BlazorDay02;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True")
            );

            builder.Services.AddCors(options =>
                options.AddPolicy("myPolicy", PolicyOptions =>
                            PolicyOptions.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
                );


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("myPolicy");

            app.MapControllers();

            app.Run();
        }
    }
}