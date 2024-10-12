﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
