using Shop.Entities.Customers;
using Shop.Services.Customers.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Customers.Contracts
{
    public interface CustomerRepository
    {
        public Task Add(Customer customer);
        public Task<List<GetAllCustomersDto>> GetAll();
        public Task<bool> IsExist(int id);
    }
}
