using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November3Practice.Models
{
    internal class Bus : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bus is going");
        }
    }
}
