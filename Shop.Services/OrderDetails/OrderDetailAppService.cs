using Shop.Entities.OrderDetails;
using Shop.Entities.Products;
using Shop.Services.Contracts;
using Shop.Services.Customers.Contracts;
using Shop.Services.OrderDetails.Contracts;
using Shop.Services.OrderDetails.Contracts.Dtos;
using Shop.Services.Orders;
using Shop.Services.Orders.Contracts;
using Shop.Services.Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.OrderDetails
{
    public class OrderDetailAppService(
        OrderDetailRepository orderDetailRepository
        , OrderRepository orderRepository
        , ProductRepository productRepository
        , UnitOfWorks unitOfWork)
        : OrderDetailService
    {
        public async Task<int> Add(AddOrderDetailDto dto, int productId, int orderId)
        {
            var product = await productRepository.GetById(productId)
            ?? throw new Exception("product not found");
            var order = await orderRepository.GetById(orderId)
                ?? throw new Exception("order not found");
            if (dto.ProductCount > product.Count)
                throw new Exception("out of stack");
            var orderDetail = new OrderDetail()
            {
                ProductCount = product.Count - dto.ProductCount,
                OrderId = orderId,
                ProductId = productId
            };
            await orderDetailRepository.Add(orderDetail);
            order.TotalPrice = orderDetail.ProductCount * product.Price;
            await unitOfWork.Complete();
            return orderDetail.Id;
        }
        //public async Task UpdateTotalPrice (int orderId)
        //{
        //    var dto = await orderDetailRepository.OrderPrices(orderId)
        //          ?? throw new Exception("order not found");
        //    var totalPrice =  dto.Prices.Sum();

        //   var order= await orderRepository.GetById(orderId)
        //        ?? throw new Exception("order not found");

        //    order.TotalPrice = totalPrice;
        //   await  unitOfWork.Complete();


        //}
        public async Task<List<GetAllOrderDetailsDto>> GetAllOrderDetails(int orderId)
        {
           return await orderDetailRepository.GetAllOrderDetails(orderId);
         }
    }

}
