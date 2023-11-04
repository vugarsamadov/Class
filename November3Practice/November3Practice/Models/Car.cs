using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November3Practice.Models
{
    internal class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is going");
        }


        public static bool operator > (Car car1, Car car2)
        {
            return car1.Price > car2.Price;
        }

        public static bool operator < (Car car1, Car car2)
        {
            return car1.Price < car2.Price;
        }

    }
}
