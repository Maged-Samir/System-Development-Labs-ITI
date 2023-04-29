using Grpc.Core;
using gRPCTask.Data;
using gRPCTask.InventoryService.Protos;
using static gRPCTask.InventoryService.Protos.Inventory;

namespace gRPCTask.InventoryService.Services
{
    public class InventoryService : InventoryBase 
    {
        public override Task<InventoryResponse> CheckAvailability(InventoryRequest request, ServerCallContext context)
        {
            var item = OrderData.Orders.FirstOrDefault(o => o.ItemId == request.ItemId);
            bool available = item != null && item.Quantity > 0;

            return Task.FromResult(new InventoryResponse { Available = available });
        }
    }
}
