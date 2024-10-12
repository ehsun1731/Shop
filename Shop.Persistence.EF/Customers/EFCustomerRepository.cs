using Microsoft.EntityFrameworkCore;
using Shop.Entities.Customers;
using Shop.Entities.OrderDetails;
using Shop.Entities.Orders;
using Shop.Entities.Products;
using Shop.Services.Customers.Contracts;
using Shop.Services.Customers.Contracts.Dtos;
using Shop.Services.Orders.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.Customers
{
    public class EFCustomerRepository(EFDataContext context) : CustomerRepository
    {
        public async Task Add(Customer customer)
        {
            await context.Set<Customer>().AddAsync(customer);
          
        }
        public async Task<List<GetAllCustomersDto>> GetAll()
        {
           return await context.Set<Customer>().Select(_ => new GetAllCustomersDto
            {
                Name=_.Name,
                PhoneNumber=_.PhoneNumber

            }).ToListAsync();

        }
        public async Task <Customer>GetCustomerByIdDto(int id)
        {
            return await context.Set<Customer>().FirstOrDefaultAsync(_ => _.Id == id);
        }
        public async Task<bool> IsExist(int id)
        {
            return await context.Set<Customer>().AnyAsync(_ => _.Id == id);
        }


    }
}
