using System;
using System.Collections.Generic;
using System.Text;

namespace October20.Models
{
    internal class FrontEndDeveloper : Developer
    {
        public FrontEndDeveloper(string Name, string Surname, byte Experience, int Salary, string[] knownLanguages, int CodeLineCount)
            : base(Name, Surname, Experience, Salary, knownLanguages)
        {
            this.CodeLineCount = CodeLineCount;
        }

        public int CodeLineCount;
    }
}
