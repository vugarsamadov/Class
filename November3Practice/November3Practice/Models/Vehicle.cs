using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November3Practice.Models
{
    internal abstract class Vehicle
    {
        public decimal Price { get; set; }

        public abstract void Drive();
    }
}
