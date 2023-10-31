using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    internal abstract class P
    {
        public static int _i;
        public int I { get; set; }

        public P()
        {
            _i += 1;
            I = _i;
            Console.WriteLine("SAFfasdfgag");
        }
    }
}
