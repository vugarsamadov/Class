using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz22
{
    internal class A
    {
        public A()
        {
            Console.WriteLine("A created");
        }

    }

    internal class B : A
    {
        public B(string a):base()
        {
            Console.WriteLine(a+  "BBB");
        }
        public B() 
        {
            Console.WriteLine("F");
        }
    }
}
