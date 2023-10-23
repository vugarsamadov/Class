using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace October23Practice.Models
{
    internal class Person
    {
        private string _name;
        private int _age;
        private string _phoneNumber;

        private string _surname;
        private DateTime _birthday;


        public string PhoneNumber 
        {
            get => _phoneNumber;
            set => _phoneNumber = IsValidPhoneNumber(value.Trim()) ? value.Trim() : _phoneNumber;
        }
        
        public string Name 
        {
            get => _name;
            set => _name = IsValidName(value) ? value : _name;
        }

        public int Age 
        {
            get => _age;
            set => _age = IsValidAge(value) ? value : _age;
        }

        public int GetAge() => _age;
        public string GetName() => _name;

        public void SetAge(int Age)
        {
            _age = IsValidAge(Age) ? Age : 0;
        }
        public void SetName(string Name)
        {
            _name = IsValidName(Name) ? Name : null!;
        }


        private bool IsValidName(string name)
        {
            if(name.Length < 2)
            {
                Console.WriteLine("Name invalid!");
                return false;
            }
            return true;
        }
        private bool IsValidAge(int age)
        {
            if(age < 16)
            {
                Console.WriteLine("Age is smaller than 16!");
                return false;
            }
            return true;
        }
        
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            bool check = phoneNumber.Length == 13 && phoneNumber.StartsWith("+994");
            if(!check)
                Console.WriteLine("Phone Number invalid!");
            return check;
        }

    }
}
