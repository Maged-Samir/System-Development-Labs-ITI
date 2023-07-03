using ITI.Revision.WebAPI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

namespace ITI.Revision.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region ConnectionString
            //ConnectionString
            var connectionString = builder.Configuration.GetConnectionString("SchoolDbConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            #endregion

            //builder.Services.AddControllers();
            #region handel refrence loop cycle
            //handel refrence loop cycle
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.MaxDepth = 32;
            });
            #endregion

            #region Add Identity

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            #endregion

            #region Build Authentication
            //to know style of Authentication we need package
            //Install-Package Microsoft.aspnetcore.authentication.jwtbearer

            builder.Services.AddAuthentication(options =>
            {
                //Used Authentication Schema
                options.DefaultAuthenticateScheme = "CoolAuthentication";

                options.DefaultChallengeScheme = "CoolAuthentication";

            })
                //Used Challange Authentication Schema
                .AddJwtBearer("CoolAuthentication", options =>
                {
                    //Generate Secrite Key 
                    var SecritKeySting = builder.Configuration.GetValue<string>("SecritKey") ?? string.Empty;
                    var SecritKeyInBytes = Encoding.ASCII.GetBytes(SecritKeySting);
                    var SecritKey = new SymmetricSecurityKey(SecritKeyInBytes);

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = SecritKey,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });

            #endregion

            #region Authorization

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AllowManagers", policy =>
                {
                    policy.RequireClaim("Role", "Manager");
                });

                // As another Role in Our System
                //options.AddPolicy("AllowEmployees", policy =>
                //{
                //    policy.RequireClaim("Role", "Employee");
                //});

            });

            #endregion


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

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}