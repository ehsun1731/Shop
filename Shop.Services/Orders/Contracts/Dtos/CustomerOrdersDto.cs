using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Orders.Contracts.Dtos
{
    public class CustomerOrdersDto
    {
        public string CustomerName { get; set; }
        public List<string>  ProductTitles { get; set; }
    }
}
