using ITI.Revision.MVC.CustomMiddlewares;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ITI.Revision.MVC.Data;
using ITI.Revision.MVC.Services;
using ITI.Revision.MVC.Filters;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace ITI.Revision.MVC
{
    public class Program
    {
        //private static int requestCount = 0;
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICategoryService, CategoryService>(); //Register Custom Servoices

            builder.Services.AddScoped<ExecutionTimeFilter>(); //Custom filter

            builder.Services.AddSession(s=>s.IdleTimeout=TimeSpan.FromSeconds(20));  // Session 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Custome inline Middellware to store requests paths 
            //app.Use(async (context, next) =>
            //{
            //    requestCount++;
            //    // Log the request
            //    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path},Total Requests: {requestCount}");

            //    // Disable browser caching
            //    context.Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
            //    context.Response.Headers["Pragma"] = "no-cache";
            //    context.Response.Headers["Expires"] = "0";


            //    // Call the next middleware in the pipeline
            //    await next.Invoke();
            //});

            //Class-based Middleware
            //app.UseMiddleware<RequestCounterMiddleware>();


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}