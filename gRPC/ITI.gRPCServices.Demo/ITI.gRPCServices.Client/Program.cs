using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using ITI.gRPCServices.Server;
using ITI.gRPCServices.Server.Protos;

namespace ITI.gRPCServices.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var greeterChannel = GrpcChannel.ForAddress("https://localhost:7191");
            var greeterClient = new Greeter.GreeterClient(greeterChannel);

            Console.WriteLine("Please Enter Your Name:");
            string name = Console.ReadLine();

            var greeterResponse = await greeterClient.SayHelloAsync(new HelloRequest { Name = name });
            Console.WriteLine("Greeter Response: " + greeterResponse.Message);

            var timeChannel = GrpcChannel.ForAddress("https://localhost:7191");
            var timeServiceClient = new TimeService.TimeServiceClient(timeChannel);

            var timeResponse = await timeServiceClient.GetCurrentTimeAsync(new ITI.gRPCServices.Server.Protos.Empty());
            Console.WriteLine("Current Time: " + timeResponse.CurrentTime);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}