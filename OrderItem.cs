using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Models
{
    public class OrderItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }
}
