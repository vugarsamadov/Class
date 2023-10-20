using October20Practice.Models;
using System;

namespace October20Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford","Ciera","Yellow",2003,360,2,"RallyCar");
            Console.WriteLine(car.GetMaxSpeed());


            Plane plane = new Plane("Airbus", "A400M", "Grey", 1997, 825, 116, false);
            Console.WriteLine(plane.GetMaxSpeed());
            
            Plane plane2 = new Plane("F16", "C/Viper", "Grey", 1980, 2100, 1, false);
            Console.WriteLine(plane.GetMaxSpeed());
            


            Vehicle[] vehicles = { car, plane, plane2};

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Model} {vehicle.Brand} produced in {vehicle.ProducedYear}");
            }

            // ----

            Console.WriteLine(IndexOf("Vugar", 'u'));
            Console.WriteLine(IndexOf("Vugar", "ug"));
        }

        static int IndexOf(string target,char searchTerm)
        {
            for(int i = 0;i<target.Length;i++)
            {
                if (target[i] == searchTerm)
                    return i;
            }
            return -1;
        }

        static int IndexOf(string target,string searchTerm)
        {
            int matchCount = 0;
            int j = 0;
            for(int i = 0;i < target.Length; i++)
            {
                if(j < searchTerm.Length)
                {
                    if (target[i] == searchTerm[j])
                    {
                        j += 1;
                        matchCount++;                        
                    }
                    else 
                    {
                        matchCount = 0;
                        j = 0;
                    }
                }
                if (matchCount == searchTerm.Length)
                {
                    return i-searchTerm.Length+1;
                }
            }
            return -1;
        }



    }



    


}
