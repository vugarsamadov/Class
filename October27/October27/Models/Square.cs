using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace October27.Models
{
    internal class Square : Figure
    {
        private int _side;

        public Square(int side)
        {
            Side = side;
        }

        public int Side 
        {
            get => _side;
            set => _side = CheckSideForNegative(value);
        }

        public override int CalcArea()
        {
            return Side * Side;
        }
    }
}
