using Microsoft.EntityFrameworkCore;
using Shop.Entities.Customers;
using Shop.Entities.OrderDetails;
using Shop.Entities.Orders;
using Shop.Entities.Products;
using Shop.Services.OrderDetails.Contracts.Dtos;
using Shop.Services.Orders.Contracts;
using Shop.Services.Orders.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.Orders
{
    public class EFOrderRepository(EFDataContext context) : OrderRepository
    {
        public async Task Add(Order order)
        {
           await context.Set<Order>().AddAsync(order);
        }

        public async Task<Order> GetById(int id)
        {
          return await context.Set<Order>().FirstOrDefaultAsync(_ => _.Id == id);
        }
       
        public async Task<List<CustomerOrdersDto>> GetCustomerOrders(int customerId)
        {
            

           return await(from order in context.Set<Order>()
                        where order.CustomerId==customerId
                       join customer in context.Set<Customer>()
                       on order.CustomerId equals customer.Id
                          join orderDetail in context.Set<OrderDetail>()
                          on order.Id equals orderDetail.OrderId
                          join product in context.Set<Product>()
                          on orderDetail.ProductId equals product.Id
                          into tempProducts
                          from oproducts in tempProducts.DefaultIfEmpty()
                          select new CustomerOrdersDto
                          {
                              CustomerName = customer.Name,
                              ProductTitles = tempProducts.Select(p => p.Title).ToList()

                          }).ToListAsync();
         
        }
      
        
       
    }
}
