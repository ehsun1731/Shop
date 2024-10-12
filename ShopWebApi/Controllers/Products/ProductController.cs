using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Services.Products.Contracts;
using Shop.Services.Products.Contracts.Dtos;

namespace ShopWebApi.Controllers.Products
{
    [Route("api/Products")]
    [ApiController]
    public class ProductController(ProductService service) : ControllerBase
    {
        [HttpPost]
        public async Task <int >Creat([FromBody]AddProductDto dto)
        {
            return await service.Add(dto);
        }
        [HttpGet]
        public  async Task<List<ShowProductsDto>> GetAll(string? title)
        {
            return await service.GetAll(title);
        }
        [HttpPatch("{id}")]
        public async Task Update([FromBody]UpdateproductDto dto,[FromRoute] int id)
        {
            await service.Update(dto,id);
        }
        [HttpDelete("{id}")]
        public async Task Delete([FromRoute]int id)
        {
           await service.Delete(id);
        }
    }
}
