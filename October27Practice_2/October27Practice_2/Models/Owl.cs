using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October27Practice_2.Models
{
    internal class Owl : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Owl is eating!");
        }

        public override void Fly()
        {
            Console.WriteLine("Owl is flying!");
        }
    }
}
