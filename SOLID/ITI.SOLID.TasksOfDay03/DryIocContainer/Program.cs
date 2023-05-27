using DryIoc;
using DryIoc.ImplementationByCode;
using Microsoft.Extensions.Configuration;

namespace DryIocContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ImplementationByCode
            var container = new Container();

            // Register your dependencies
            container.Register<ILogger, Logger>();
            container.Register<IEmailService, EmailService>();
            container.Register<BlogService>();

            // Resolve the dependency
            var blogService = container.Resolve<BlogService>();

            // Use the resolved dependency
            blogService.CreateBlogPost("Sample Blog Post", "This is a sample blog post.", "John Doe");

            
            #endregion

            //IConfiguration configuration = new ConfigurationBuilder()
            //.AddJsonFile("containerConfig.json")
            //.Build();

            //var container = new Container();

            //// Read the dependency configurations from the configuration file
            //var loggerType = configuration["Logging:LoggerType"];
            //var emailServiceType = configuration["EmailService:ServiceType"];

            //// Register your dependencies based on the configurations
            //container.Register<ILogger, Logger>(Reuse.Singleton); // Example registration using Reuse.Singleton
            //container.Register<IEmailService, EmailService>(Reuse.Transient); // Example registration using Reuse.Transient
            //container.Register<BlogService>();

            //// Resolve the dependency
            //var blogService = container.Resolve<BlogService>();

            //// Use the resolved dependency
            //blogService.CreateBlogPost("Sample Blog Post", "This is a sample blog post.", "John Doe");
        }
    }
}