using System;
using System.Collections.Generic;
using System.Text;

namespace October20Practice.Models
{
    internal class Plane : Vehicle
    {
        public int SeatCount;
        public bool HasBusinessClass;

        public Plane(string Brand, string Model, string Colour,
            int ProducedYear, int MaxSpeed, int SeatCount, bool HasBusinessClass)
            : base(Brand, Model, Colour, ProducedYear, MaxSpeed)
        {
            this.SeatCount = SeatCount;
            this.HasBusinessClass = HasBusinessClass;
        }
    }
}
