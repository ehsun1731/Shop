using Shop.Services.OrderDetails.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.OrderDetails.Contracts
{
    public interface OrderDetailService
    {
        public  Task<int> Add(AddOrderDetailDto dto, int ProductId, int OrderId);

        public Task<List<GetAllOrderDetailsDto>> GetAllOrderDetails(int orderId);

    }
}
