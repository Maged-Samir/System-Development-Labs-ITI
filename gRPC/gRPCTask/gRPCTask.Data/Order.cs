using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPCTask.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Balance { get; set; }
    }
}
