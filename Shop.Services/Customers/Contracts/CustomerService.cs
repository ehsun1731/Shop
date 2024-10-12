using Shop.Services.Customers.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Customers.Contracts
{
    public interface CustomerService
    {
      public Task <int> AddCustomer(AddCustomerDto addCustomerDto);
        public Task<List<GetAllCustomersDto>> GetAll();
    }
}
