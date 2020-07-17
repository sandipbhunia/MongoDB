using Flippy.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Repository
{
    public class FlippyRepository : IFlippyRepository
    {
        private readonly IFlippyContext _context;

        public FlippyRepository(IFlippyContext context)
        {
            _context = context;
        }

        public async Task Create(CustomerOrder customerOrder)
        {
            await _context.CustomerOrders.InsertOneAsync(customerOrder);
        }

        public async Task<IEnumerable<CustomerOrder>> GetAllCustomerOrderByCustomerId(int customerId)
        {
            return await _context
                            .CustomerOrders
                            .Find(o=>o.CustomerId==customerId)
                            .ToListAsync();

        }

        public async Task<CustomerOrder> GetCustomerOrderByOrderId(int orderId)
        {
            FilterDefinition<CustomerOrder> filter = Builders<CustomerOrder>.Filter.Eq(co=>co.Order.OrderId,orderId);
            return await _context
                           .CustomerOrders
                           .Find(filter)
                           .FirstOrDefaultAsync();
        }

        public async  Task<bool> Update(CustomerOrder customerOrder)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetNextId()
        {
            return(int ) await _context.CustomerOrders.CountDocumentsAsync(new BsonDocument()) + 1;
        }

    }
}
