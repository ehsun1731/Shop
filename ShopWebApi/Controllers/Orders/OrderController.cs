using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Services.Customers.Contracts;
using Shop.Services.Orders.Contracts;

namespace ShopWebApi.Controllers.Orders
{
    [Route("api/Orders")]
    [ApiController]
    public class OrderController(OrderService service) : ControllerBase
    {
        [HttpPost("{customerId}")]
        public async Task<int> Creat([FromRoute] int customerId)
        {
            return await service.Add(customerId);
        }
    }
}
