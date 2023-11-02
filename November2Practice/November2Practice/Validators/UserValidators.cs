using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace November2Practice.Validators
{
    internal static class UserValidators
    {
        private const string PhoneNumberRegex = @"(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}";
        private const string PasswordRegex = @"[A-Z]*[0-9]*";
        
        public static bool ValidateName(string name) => name.Length >= 2 && name.Length <= 30;
        public static bool ValidateAge(int age) => age > 0;
        public static bool ValidatePhoneNumber(string phoneNumber) => Regex.Match(phoneNumber, PhoneNumberRegex).Success;
        public static bool ValidatePassword(string password)
        {
            if(password.Length < 8) return false;

            return Regex.Match(password, PasswordRegex).Success;
        }




    }
}
