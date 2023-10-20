using System;
using System.Collections.Generic;
using System.Text;

namespace October20.Models
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
