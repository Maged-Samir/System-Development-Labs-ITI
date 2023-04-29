using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPCTask.Data
{
    public class OrderData
    {
        public static List<Order> Orders = new List<Order>()
    {
        new Order() { OrderId = 1, UserId = 1, ItemId = 1, Price = 10, Quantity = 2 ,Balance=1000},
        new Order() { OrderId = 2, UserId = 2, ItemId = 2, Price = 5, Quantity = 3 ,Balance = 1000},
    };

    }
}
