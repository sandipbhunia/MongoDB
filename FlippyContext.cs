using Flippy.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Repository
{
    public class FlippyContext: IFlippyContext
    {
        private readonly IMongoDatabase _db;

        public FlippyContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }

        public IMongoCollection<CustomerOrder> CustomerOrders => _db.GetCollection<CustomerOrder>("CustomerOrder");

    }
}
