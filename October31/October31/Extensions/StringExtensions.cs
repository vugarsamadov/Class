using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October31.Extensions
{
    internal static class StringExtensions
    {

        public static bool CustomContains(this string s,string target) 
        {
            s = s.ToLower();
            target = target.ToLower();
            int counter = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (counter == target.Length)
                    return true;

                if (s[i] == target[counter])
                    counter++;
                else
                    counter = 0;
            }
            return counter == target.Length;
        }

    }
}
