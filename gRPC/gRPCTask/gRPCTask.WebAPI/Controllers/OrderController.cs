using Grpc.Net.Client;
using gRPCTask.Data;
using gRPCTask.InventoryService.Protos;
using gRPCTask.PaymentService.Protos;
using Microsoft.AspNetCore.Mvc;
using static gRPCTask.InventoryService.Protos.Inventory;
using static gRPCTask.PaymentService.Protos.Payment;

namespace gRPCTask.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static List<Order> _orders = OrderData.Orders;

        // GET api/order
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orders);
        }

        // POST api/order
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            order.OrderId = _orders.Max(o => o.OrderId) + 1;
            _orders.Add(order);

            #region InvetoryService
            var channel = GrpcChannel.ForAddress("https://localhost:7202");
            var client = new InventoryClient(channel);
            var request=new InventoryRequest { ItemId= order.ItemId };
            var response=await  client.CheckAvailabilityAsync(request);

            //var request = new CheckAvailability { ItemId = order.ItemId, Quantity = order.Quantity };
            //var response = await client.CheckAvailabilityAsync(request);
            #endregion

            #region PaymentService
            var channel2 = GrpcChannel.ForAddress("https://localhost:7172");
            var client2 = new PaymentClient(channel2);
            var request2 = new PaymentRequest { UserId = order.UserId ,Price=order.Price};
            var response2 = await client2.CheckBalanceAsync(request2);

            //var request = new CheckAvailability { ItemId = order.ItemId, Quantity = order.Quantity };
            //var response = await client.CheckAvailabilityAsync(request);
            #endregion


            // Check if the item is available
            if (!response.Available)
            {
                // Remove the order from the list
                OrderData.Orders.Remove(order);
                return BadRequest("Item is not available in the requested quantity.");
            }

            // Check if the Balance is available
            if (!response2.Available)
            {
                // Remove the order from the list
                OrderData.Orders.Remove(order);
                return BadRequest("Balance Of Selected User is not enough");
            }


            return CreatedAtAction(nameof(Get), new { id = order.OrderId }, order);
        }

    }
}
