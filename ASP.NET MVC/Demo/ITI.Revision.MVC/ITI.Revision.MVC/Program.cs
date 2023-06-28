using ITI.Revision.MVC.CustomMiddlewares;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;

namespace ITI.Revision.MVC
{
    public class Program
    {
        //private static int requestCount = 0;
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSession(s=>s.IdleTimeout=TimeSpan.FromSeconds(20));

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