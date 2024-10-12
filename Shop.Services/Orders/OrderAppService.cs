using Shop.Entities.Customers;
using Shop.Entities.Orders;
using Shop.Services.Contracts;
using Shop.Services.Customers.Contracts;
using Shop.Services.Orders.Contracts;
using Shop.Services.Orders.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Orders
{
    public class OrderAppService(OrderRepository orderRepository,CustomerRepository customerRepository, UnitOfWorks unitOfWork) : OrderService
    {
        public async Task<int> Add(int customerId)
        {
            if (!(await customerRepository.IsExist(customerId)))
                  throw new Exception("customer not found");
            var order = new Order()
            {
                CustomerId = customerId
            };
            await orderRepository.Add(order);
            await unitOfWork.Complete();
            return order.Id;
        }
        public async Task<GetOrderByIddto>GetById(int customerId)
        {
           var order= await orderRepository.GetById(customerId);
            return  new GetOrderByIddto()
            {
                CustomerId = customerId
            };
        }
        

       
    }
}
