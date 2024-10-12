using Shop.Entities.Products;
using Shop.Services.Contracts;
using Shop.Services.Customers.Contracts.Dtos;
using Shop.Services.Products.Contracts;
using Shop.Services.Products.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Products
{
    public class ProductAppService(ProductRepository repository, UnitOfWorks unitOfWork) : ProductService
    {
        public async Task<int> Add(AddProductDto dto)
        {
            var product = new Product()
            {
                Title = dto.Title,
                Count = dto.Count,
                Price = dto.Price

            };
            await repository.Add(product);
            await unitOfWork.Complete();
            return product.Id;

        }
        public async Task<List<ShowProductsDto>> GetAll(string? title)
        {
            return await repository.GetAll(title);
        }
        public async Task Update(UpdateproductDto dto,int id)
        {
            var product = await repository.GetById(id)
                 ?? throw new Exception("Product not found");
            product.Price = dto.Price;
            product.Title = dto.Title;
            product.Count = dto.Count;
            await unitOfWork.Complete();


        }
        public async Task Delete(int id)
        {
           var product= await repository.GetById(id)
                 ?? throw new Exception("Product not found"); ;
            repository.Delete(product);
            unitOfWork.Complete();

        }
    }
}
