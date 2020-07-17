using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Models
{
    public class Order
    {
        public int OrderId { get; set; } /// auto get
        public List<OrderItem> OrderItems { get; set; }
        public string Status { get; set; } // orderplace,order accept,order reject,ready, pickup, delivered
        public String RejectReason { get; set; }
    }
}
