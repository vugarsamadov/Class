using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook.Demo.Helpers
{
    public static class Validator
    {

        public static bool ValidateUserName(string userName)
        {
            return userName.Length > 4;
        }
        public static bool ValidatePassword(string password) 
        {
            return password.Length > 6;
        }
    }
}
