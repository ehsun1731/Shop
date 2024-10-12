using Shop.Entities.Products;
using Shop.Services.Products.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Products.Contracts
{
    public interface ProductRepository
    {
        public Task Add(Product product);
        public  Task<List<ShowProductsDto>> GetAll(string? title);
        public Task<Product> GetById(int id);
        public void Delete(Product product);
    }
}
