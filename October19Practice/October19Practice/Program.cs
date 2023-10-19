using System;

namespace October19Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mitsibushi","LancerGT","red",4);
            Car car2 = new Car("Nissan", "240SX SE","red",2);
            Car car3 = new Car("Ford", "Fiesta XR2","black",4);

            Car[] cars = new Car[] {car1,car2,car3};
            
            foreach (Car car in cars) 
            {
                Console.WriteLine(car.GetDetails());
            }


        }
    }
}
