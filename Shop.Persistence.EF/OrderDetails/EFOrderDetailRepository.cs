using Microsoft.EntityFrameworkCore;
using Shop.Entities.OrderDetails;
using Shop.Entities.Products;
using Shop.Services.OrderDetails.Contracts;
using Shop.Services.OrderDetails.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.OrderDetails
{
    public class EFOrderDetailRepository(EFDataContext context) : OrderDetailRepository
    {
        public async Task Add(OrderDetail orderDetail)
        {
          await  context.Set<OrderDetail>().AddAsync(orderDetail);
        }

        //public async Task<OrderPricesDto> OrderPrices(int orderId)
        //{
        //    var prices = await (from orderDetail in context.Set<OrderDetail>()
        //                        where orderDetail.OrderId == orderId
        //                        join product in context.Set<Product>()
        //                        on orderDetail.ProductId equals product.Id
        //                        select product.Price)
        //                 .ToListAsync();


        //    return new OrderPricesDto
        //    {
        //        Prices = prices
        //    };

        //}
        public async Task<List<GetAllOrderDetailsDto>> GetAllOrderDetails(int orderId)
        {
            return await (from orderDetail in context.Set<OrderDetail>()
                          where orderDetail.OrderId == orderId
                          join product in context.Set<Product>()
                          on orderDetail.ProductId equals product.Id
                          select new GetAllOrderDetailsDto
                          {
                              ProductCount=orderDetail.ProductCount,
                              ProductTitle=product.Title,
                              ProductPrice=product.Price


                          }).ToListAsync();
        }

    }
}
