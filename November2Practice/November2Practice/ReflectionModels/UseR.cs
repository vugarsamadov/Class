using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November2Practice.ReflectionModels
{
    public class UseR
    {
        private int _id;
        private string _name;
        private static int _age;

        public override string ToString()
        {
            return $" {_id} {_name} {_age}";
        }

        static void ChangeAge(int age)
        {
            _age = age;
        }
    }
}
