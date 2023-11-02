using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November2Practice.Utilities.Exceptions
{
    internal class InvalidAgeExeption : Exception
    {
        public InvalidAgeExeption(string? message) : base(message)
        {
        }
    }
}
