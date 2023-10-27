using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October27Practice.Models
{
    internal class Notebook : Product
    {
        private string _brand;

        public string Brand
        {
            get => _brand;
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    Console.WriteLine("Model Name is invalid");
                }
                else
                    _brand = value;
            }
        }
        public string Model { get; set; }
        
        private int _ram;
        public int RAM 
        {
            get => _ram;
            set
            {
                if(_ram >128 || _ram < 0)
                    Console.WriteLine("Ram invalid");
                else
                    _ram = value;
            }
        }
        private int _storage;
        public int Storage
        {
            get => _storage;
            set
            {
                if (_storage < 0)
                    Console.WriteLine("Storage invalid");
                else
                    _storage = value;
            }
        }

        public Notebook(string model, int count, decimal price) : base(count,price)
        {
            Model = model;
        }

        public Notebook(int count, decimal price, string brand, string model, int ram, int storage) : base(count, price)
        {
            Brand = brand;
            Model = model;
            RAM = ram;
            Storage = storage;
        }
    }
}
