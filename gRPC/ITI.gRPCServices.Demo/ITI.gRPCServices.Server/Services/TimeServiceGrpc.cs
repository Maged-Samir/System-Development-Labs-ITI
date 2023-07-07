using Grpc.Core;
using ITI.gRPCServices.Server.Protos;

namespace ITI.gRPCServices.Server.Services
{
    public class TimeServiceGrpc : TimeService.TimeServiceBase
    {
        public override Task<TimeResponse> GetCurrentTime(Empty request, ServerCallContext context)
        {
            string currentTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            return Task.FromResult(new TimeResponse { CurrentTime = currentTime });
        }
    }
}
