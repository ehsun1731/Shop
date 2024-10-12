using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Products.Contracts.Dtos
{
    public class GetProductById
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int AvailableCount { get; set; }
    }
}
