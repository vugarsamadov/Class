using System;
using System.Collections.Generic;
using System.Text;

namespace October20.Models
{
    internal class BackEndDeveloper : Developer
    {
        public int KnownPatternCount;

        public BackEndDeveloper(string Name, string Surname, byte Experience, int Salary, string[] knownLanguages, int KnownPatternCount)
        : base(Name, Surname, Experience, Salary, knownLanguages)
        {
            this.KnownPatternCount = KnownPatternCount;
        }
    }
}
