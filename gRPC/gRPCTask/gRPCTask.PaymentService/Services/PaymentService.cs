using Grpc.Core;
using gRPCTask.Data;
using gRPCTask.PaymentService.Protos;
using static gRPCTask.PaymentService.Protos.Payment;

namespace gRPCTask.PaymentService.Services
{
    public class PaymentService:PaymentBase 
    {
        public override Task<PaymentResponse> CheckBalance(PaymentRequest request, ServerCallContext context)
        {
             var user = OrderData.Orders.FirstOrDefault(o => o.UserId == request.UserId);
             bool available = user != null && user.Balance > request.Price;
            return Task.FromResult(new PaymentResponse { Available=available});
           
        }
    }
}
