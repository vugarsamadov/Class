using System;
using System.Collections.Generic;
using System.Text;

namespace October20Practice.Models
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int ProducedYear;
        public int MaxSpeed;

        public Vehicle(string brand, string model, string colour, int producedYear, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            ProducedYear = producedYear;
            MaxSpeed = maxSpeed;
        }

        public string GetMaxSpeed()
        {
            string prompt = $"{Brand} {Model} can move at max speed of {MaxSpeed} km/h";
            return prompt ;
        }


    }
}
