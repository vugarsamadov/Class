using AuthorBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auth = AuthorBook.Demo.Authorization.Authorization;
namespace AuthorBook.Demo.Helpers
{
    public static class UserHelper
    {
        public static User GetUserFromUser()
        {
            var name = Helper.PromptAndGetNonEmptyString("Enter name: ");

            string surname = Helper.PromptAndGetNonEmptyString("Enter surname: ");


            string userName = GetUserUserName();

            var password = GetUserFromUser();

        }


        public static string GetUserUserName() 
        {
            string userName;
            do
            {
                userName = Helper.PromptAndGetNonEmptyString("Enter username: ");
                if (Auth.CheckIfUserExists(userName))
                    Console.WriteLine("Username is already registered!");
            } while (Auth.CheckIfUserExists(userName));
            return userName;
        }

        public static string GetPasswordFromUser()
        {
            string password;

            do
            {
                password = Helper.PromptAndGetNonEmptyString("Enter password: ");
                 
            } while (Auth.CheckIfUserExists(password));
        }

    }
}
