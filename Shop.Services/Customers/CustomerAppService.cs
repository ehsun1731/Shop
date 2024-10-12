using Shop.Entities.Customers;
using Shop.Services.Contracts;
using Shop.Services.Customers.Contracts;
using Shop.Services.Customers.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Customers
{
    public class CustomerAppService(CustomerRepository repository, UnitOfWorks unitOfWork) : CustomerService
    {
        public async Task<int> AddCustomer(AddCustomerDto Dto)
        {
            var customer = new Customer()
            {
                PhoneNumber = Dto.PhoneNumber,
                Name = Dto.Name
            };
            await repository.Add(customer);
            await unitOfWork.Complete();
            return customer.Id;
        }

        public async Task<List<GetAllCustomersDto>> GetAll()
        {
            return await repository.GetAll();
        }
    }
}
