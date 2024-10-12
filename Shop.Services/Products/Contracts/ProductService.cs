using Shop.Services.Products.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Shop.Services.Products.Contracts
{
    public interface ProductService
    {
        public  Task<int> Add(AddProductDto dto);
        public Task<List<ShowProductsDto>> GetAll(string? title);
        public Task Update(UpdateproductDto dto, int id);
        public Task Delete(int id);
    }
}
