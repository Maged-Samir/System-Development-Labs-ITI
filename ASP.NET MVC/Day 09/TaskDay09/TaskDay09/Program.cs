using Microsoft.EntityFrameworkCore;
using TaskDay09.Models;
using TaskDay09.Services;
using Microsoft.AspNetCore.Identity;
/*using TaskDay09.Data*/

namespace TaskDay09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("MyConString") ?? throw new InvalidOperationException("Connection string 'TaskDay09ContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(builder
              .Configuration.GetConnectionString("MyConString")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddScoped<ITrackRepository, TrackRepoService>();
            builder.Services.AddScoped<ITraineeRepository, TraineeRepoService>();
            builder.Services.AddScoped<ICourseRepository, CourseRepoService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseRouting();

            app.MapRazorPages();

            app.Run();
        }
    }
}