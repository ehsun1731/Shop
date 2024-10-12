using Shop.Entities.Orders;
using Shop.Services.Orders.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Orders.Contracts
{
    public interface OrderRepository
    {
        public Task Add(Order order);
        public Task<Order> GetById(int id);
        public Task<List<CustomerOrdersDto>> GetCustomerOrders(int customerId);
        
    }
}
