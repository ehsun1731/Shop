using Microsoft.EntityFrameworkCore;
using Shop.Entities.Products;
using Shop.Services.Products.Contracts;
using Shop.Services.Products.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.Products
{
    public class EFProductRepository(EFDataContext context) : ProductRepository
    {
        public async Task Add(Product product)
        {
           await context.Set<Product>().AddAsync(product);
           
        }
        public async  Task <List<ShowProductsDto>>GetAll(string? title)
        {
            return await context.Set<Product>()
                .Where(_ => _.Title == title)
                .Select(_ => new ShowProductsDto
                {
                    Title=_.Title,
                    Price=_.Price,
                    Count=_.Count
                }).ToListAsync();
        }
        public async Task <Product> GetById(int id)
        {
            return await context.Set<Product>().FirstOrDefaultAsync(_ => _.Id == id);
        }
       public void  Delete(Product product)
        {
             context.Set<Product>().Remove(product);
        }
    }
}
