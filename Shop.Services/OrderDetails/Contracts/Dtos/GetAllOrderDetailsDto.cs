using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.OrderDetails.Contracts.Dtos
{
    public class GetAllOrderDetailsDto
    {

        public string ProductTitle { get; set; }
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }
    }
}
