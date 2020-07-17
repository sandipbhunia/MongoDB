using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Models
{
    public class CustomerOrder
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContact { get; set; }
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopLocation { get; set; }
        public Order Order { get; set; }
    }
}
