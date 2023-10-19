using System;
using System.Collections.Generic;
using System.Text;

namespace October19Practice
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public byte SeatNumber;

        public string DefaultColor = "black";
        public byte DefaultNumberOfSeats = 0;


        public Car(string brand, string model, string color, byte seatNumber)
        {
            Brand = brand;
            Model = model;
            Color = color == null ? DefaultColor : color;
            SeatNumber = seatNumber == 0 ? DefaultNumberOfSeats: seatNumber;
        }

        public Car(string brand, string model) : this(brand, model, null, 0){ }


        public string GetDetails()
        {
            return $"Brand: {Brand}, Model: {Model}, Color: {Color}, SeatNumber: {SeatNumber}";
        }
        

    }
}
