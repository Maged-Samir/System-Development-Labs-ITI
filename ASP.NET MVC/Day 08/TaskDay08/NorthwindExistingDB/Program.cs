using Microsoft.EntityFrameworkCore;
using NorthwindExistingDB.Models;
using NuGet.Configuration;
using System.Configuration;

namespace NorthwindExistingDB
{
    public class Program
    {

        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();

            //builder.Services.Configure<NorthwindContext>(builder.Configuration.GetSection("MyConString"));
            builder.Services.AddDbContext<NorthwindContext>(x => x.UseSqlServer(builder
                .Configuration.GetConnectionString("MyConString")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

           
               

                //Custom Routing for our Start Page
                app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Product}/{action=Index}/{id?}");


           


            app.Run();
        }
    }
}