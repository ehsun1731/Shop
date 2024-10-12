using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Services.Customers.Contracts;
using Shop.Services.Customers.Contracts.Dtos;

namespace ShopWebApi.Controllers.Customers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomerController(CustomerService service) : ControllerBase
    {
        [HttpPost]
        public async Task<int> Creat([FromBody] AddCustomerDto dto)
        {
            return await service.AddCustomer( dto);
        }
        [HttpGet]
        public async Task <List<GetAllCustomersDto>> GetAll()
        {
            return await service.GetAll();
        }
    }
}
