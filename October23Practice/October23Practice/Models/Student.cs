using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October23Practice.Models
{
    internal class Student : Person
    {
        private bool _hasScholarship;

        public bool HasScholarship  { get => _hasScholarship; set => _hasScholarship = value; }

        public override string ToString()
        {
            string prompt = HasScholarship ? "This one is such a good student" : "This one doesn't study hard";
            return prompt;
        }
    }
}
