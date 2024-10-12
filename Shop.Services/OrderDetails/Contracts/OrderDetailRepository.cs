using Shop.Entities.OrderDetails;
using Shop.Entities.Orders;
using Shop.Services.OrderDetails.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.OrderDetails.Contracts
{
    public interface OrderDetailRepository
    {
        public Task Add(OrderDetail orderDetails);
        //public Task<OrderPricesDto> OrderPrices(int orderId);
        public Task<List<GetAllOrderDetailsDto>> GetAllOrderDetails(int orderId);

    }
}
