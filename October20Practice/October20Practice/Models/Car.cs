using System;
using System.Collections.Generic;
using System.Text;

namespace October20Practice.Models
{
    internal class Car : Vehicle
    {
        public byte DoorCount;
        public string Type;

        public Car(string Brand, string Model, string Colour,
            int ProducedYear, int MaxSpeed,byte doorCount, string type) 
            :base(Brand,Model,Colour,ProducedYear,MaxSpeed)
        {
            DoorCount = doorCount;
            Type = type;
        }
    }
}
