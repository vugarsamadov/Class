using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October27.Models
{
    internal abstract class Figure
    {
        public abstract int CalcArea();

        public int CheckSideForNegative(int side)
        {
            if (side < 0)
            {
                Console.WriteLine("Negative side is not allowed!");
                return default;
            }
            else
                return side;
        }

    }
}
