using Flippy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flippy.Repository
{
    public interface IFlippyRepository
    {
        Task<IEnumerable<CustomerOrder>> GetAllCustomerOrderByCustomerId(int customerId);

        // api/1/[GET]
        Task<CustomerOrder> GetCustomerOrderByOrderId(int orderId);

        // api/[POST]
        Task Create(CustomerOrder customerOrder);

        // api/[PUT]
        Task<bool> Update(CustomerOrder customerOrder);

        Task<int> GetNextId();



    }
}
