using System;
using System.Collections.Generic;
using System.Text;

namespace October20.Models
{
    internal class Developer : Employee
    {
        public string[] KnownLanguages;

        public Developer(string Name, string Surname, byte Experience, int Salary, string[] knownLanguages)
            : base(Name,Surname, Experience, Salary)
        {
            KnownLanguages = knownLanguages;
        }

        public void WriteCode()
        {
            foreach (var language in KnownLanguages) 
            {
                Console.WriteLine($"{Name} can code in {language}");
            }
        }
    }
}
