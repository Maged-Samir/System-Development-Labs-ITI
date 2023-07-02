
using ITI.Revision.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ITI.Revision.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            
            //ConnectionString
            var connectionString = builder.Configuration.GetConnectionString("SchoolDbConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options=>
            options.UseSqlServer(connectionString));



            //builder.Services.AddControllers();

            //handel refrence loop cycle
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.MaxDepth = 32;
            });


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


            app.MapControllers();

            app.Run();
        }
    }
}