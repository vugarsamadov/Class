using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October27Practice.Models
{
    internal class Product
    {
        public int Count { get; set; }
        decimal Price { get; set; }

        public Product(int count, decimal price)
        {
            Count = count;
            Price = price;
        }
        

    }
}
