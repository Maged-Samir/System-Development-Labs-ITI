using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary;
using TaskOfBlazor;
using TaskOfBlazor.Services;

namespace TaskOfBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient<ITraineeDataService, TraineeDataService>(
               client => client.BaseAddress = new Uri("https://localhost:7032")
               );

            builder.Services.AddHttpClient<ITrackDataService, TrackDataService>(
                c => c.BaseAddress = new Uri("https://localhost:7032")
                );



            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<StaticContext>();
            await builder.Build().RunAsync();
        }
    }
}