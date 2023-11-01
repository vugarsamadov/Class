using AuthorBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook.Demo.Authorization
{
    public static class Authorization
    {

        public static List<User> Users;
        public static User CurrentLogedInUser;

        static Authorization()
        {
            Users = new();
            CurrentLogedInUser = null;
        }

        public static void Register(User user)
        {
            Users.Add(user);
            // username > 4
            // pass > 6
        }
        public static bool Login(string username, string password)
        {
            foreach (var user in Users) 
            {
                if(user.UserName == username && user.Password == password)
                    return true;
            }
            return false;
        }
        public static void Logout() 
        {
            CurrentLogedInUser = null;
        }


        public static bool CheckIfUserExists(string userName)
        {
            foreach (var user in Users)
            {
                if (user.UserName == userName)
                    return true;
            }
            return false;
        }
    }
}
