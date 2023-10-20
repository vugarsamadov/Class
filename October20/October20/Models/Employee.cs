using System;
using System.Collections.Generic;
using System.Text;

namespace October20.Models
{
    internal class Employee : Person
    {
        
        public byte Experience;
        public int Salary;

        public Employee(string Name, string Surname,byte experience, int salary)
            :base(Name, Surname)
        {
            Experience = experience;
            Salary = salary;
        }
    }
}
