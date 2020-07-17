using Flippy.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Repository
{
   public interface IFlippyContext
    {
        IMongoCollection<CustomerOrder> CustomerOrders { get; }
    }
}
