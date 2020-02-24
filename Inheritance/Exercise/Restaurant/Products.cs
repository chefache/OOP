using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Products
    {
        public Products(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
