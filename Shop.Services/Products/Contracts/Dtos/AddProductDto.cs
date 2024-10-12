using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Products.Contracts.Dtos
{
    public class AddProductDto
    {
       
        public string Title { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

    }
}
