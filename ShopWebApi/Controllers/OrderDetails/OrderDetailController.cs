using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Services.OrderDetails.Contracts;
using Shop.Services.OrderDetails.Contracts.Dtos;

namespace ShopWebApi.Controllers.OrderDetails
{
    [Route("api/OrderDetails")]
    [ApiController]
    public class OrderDetailController(OrderDetailService service) : ControllerBase
    {
        [HttpPost]
        public async Task<int> Creat([FromBody] AddOrderDetailDto dto, [FromRoute] int productId, [FromRoute] int orderId)
        {
            return await service.Add(dto, productId, orderId);
        }
        [HttpGet("{orderId}")]
        public async Task<List<GetAllOrderDetailsDto>> GetAllOrderDetails([FromRoute] int orderId)
        {
            return await service.GetAllOrderDetails(orderId);
        }
    }
}
