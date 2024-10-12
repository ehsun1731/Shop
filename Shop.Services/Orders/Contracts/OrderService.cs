using Shop.Services.Orders.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Orders.Contracts
{
    public interface OrderService
    {
        public Task<int> Add(int customerId);
        public Task<GetOrderByIddto> GetById(int customerId);
    }
}
