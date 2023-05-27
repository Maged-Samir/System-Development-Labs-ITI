using DryIoc.ImplementationByCode;
using Microsoft.Extensions.Configuration;
using SimpleInjector;

namespace SimpleInjectorContainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();

            // Register your dependencies
            container.Register<ILogger, Logger>();
            container.Register<IEmailService, EmailService>();
            container.Register<BlogService>();

            // Verify the container's configuration
            container.Verify();

            // Resolve the dependency
            var blogService = container.GetInstance<BlogService>();

            // Use the resolved dependency
            blogService.CreateBlogPost("Sample Blog Post", "This is a sample blog post.", "John Doe");








            //var container = new Container();

            //// Create a configuration builder and load the configuration from the file
            //var configurationBuilder = new ConfigurationBuilder()
            //    .AddJsonFile("containerConfig.json");

            //var configuration = configurationBuilder.Build();

            //// Register the configuration instance as IConfiguration in the container
            //container.RegisterInstance<IConfiguration>(configuration);

            //// Register your dependencies based on the configurations
            //container.Register<ILogger>(() =>
            //{
            //    var loggerType = configuration["Logging:LoggerType"];
            //    var loggerTypeInstance = Type.GetType(loggerType);

            //    if (loggerTypeInstance != null && typeof(ILogger).IsAssignableFrom(loggerTypeInstance))
            //    {
            //        return (ILogger)container.GetInstance(loggerTypeInstance);
            //    }
            //    else
            //    {
            //        // Fallback to a default implementation
            //        return new Logger();
            //    }
            //});

            //container.Register<IEmailService>(() =>
            //{
            //    var emailServiceType = configuration["EmailService:ServiceType"];
            //    var emailServiceTypeInstance = Type.GetType(emailServiceType);

            //    if (emailServiceTypeInstance != null && typeof(IEmailService).IsAssignableFrom(emailServiceTypeInstance))
            //    {
            //        return (IEmailService)container.GetInstance(emailServiceTypeInstance);
            //    }
            //    else
            //    {
            //        // Fallback to a default implementation
            //        return new EmailService();
            //    }
            //});

            //container.Register<BlogService>();

            //// Verify the container's configuration
            //container.Verify();

            //// Resolve the dependency
            //var blogService = container.GetInstance<BlogService>();

            //// Use the resolved dependency
            //blogService.CreateBlogPost("Sample Blog Post", "This is a sample blog post.", "John Doe");


        }
    }
}