using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October27.Models
{
    internal class Rectangular : Figure
    {
        private int _width;
        private int _height;

        public Rectangular(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width 
        {
            get => _width;
            set => _width = CheckSideForNegative(value);
        }
        public int Height
        {
            get => _height;
            set => _height = CheckSideForNegative(value);
        }

        public override int CalcArea()
        {
            return Width * Height;
        }
    }
}
