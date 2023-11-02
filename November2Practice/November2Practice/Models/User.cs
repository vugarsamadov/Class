using November2Practice.Utilities.Exceptions;
using November2Practice.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace November2Practice.Models
{
    internal class User
    {
        private string _name;
        public string Name { 
            get => _name; 
            
            set
            {
                if(!UserValidators.ValidateName(value))
                {
                    throw new InvalidNameException("Name must have min 2 max 30 length.");
                }
                _name = value;
            }
        }

        // min2   max 30 invalid name exception
        private int _age;
        public int Age 
        {
            get => _age;
            set
            {
                if(!UserValidators.ValidateAge(value))
                {
                    throw new InvalidAgeExeption("Age must be positive non-zero literal!");
                }
                _age = value;
            }
        }
        private string _phoneNumber = null;
        public string PhoneNumber 
        {
            get => _phoneNumber;
            set
            {
                if(!UserValidators.ValidatePhoneNumber(value))
                {
                    throw new InvalidPhoneNumberException("Provided phone number is invalid!");
                }
                _phoneNumber = value;
            }
        } 
        private string _password;
        public string Password 
        {
            get => _password;
            set
            {
                if(!UserValidators.ValidatePassword(value))
                {
                    throw new InvalidPasswordException("Password should has min 1 Uppercase 1 digit and min 8 length!");
                }
                _password = value;
            }
        } 
        
        

    }
}
