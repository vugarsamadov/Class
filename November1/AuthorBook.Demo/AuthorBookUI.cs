using AuthorBook.Core.Models;
using AuthorBook.Demo.Enums;
using AuthorBook.Demo.Helpers;
using Auth = AuthorBook.Demo.Authorization.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AuthorBook.Demo
{

    
    public class AuthorBookUI
    {
        

        private readonly InitialCommands[] NonLoggedInCommandsArray = 
            { 
                InitialCommands.Login,
                InitialCommands.Register,
                InitialCommands.GetUsers,
                InitialCommands.Quit
            };
        private readonly LoggedInCommands[] LoggedInCommandsArray =
            {
                LoggedInCommands.Logout,
                LoggedInCommands.Quit
            };

        internal void Start()
        {
            int commandInt = 0;
            do
            {
                if (IsLoggedIn())
                {
                    commandInt = (int) PromptAndGetLoggedInCommands() - 1;
                    if (commandInt == LoggedInCommandsArray.Length)
                        break;
                    HandleLoggedInCommand((LoggedInCommands) commandInt);
                }
                else
                {
                    commandInt = (int) PromptAndGetInitialCommands() - 1;
                    if (commandInt == NonLoggedInCommandsArray.Length)
                        break;
                    HandleNonLoggedInCommand((InitialCommands)commandInt);
                }
            } while (true);
        }




        public void HandleNonLoggedInCommand(InitialCommands initialCommand)
        {
            switch (initialCommand)
            {
                case InitialCommands.Login:
                    PromptUserLogin();
                    break;
                case InitialCommands.Register:
                    PromptUserRegister();
                    break;
                case InitialCommands.GetUsers:
                    PrintAllUsers();
                    break;
                
            }
        }
        
        private void PromptUserLogin()
        {
            var userName = Helper.PromptAndGetNonEmptyString("Please enter username: ");

            var password = Helper.PromptAndGetNonEmptyString("Please enter password: ");
            bool status = Auth.Login(userName, password);
            if (status) 
            {
                Console.WriteLine("Logged in successfully!");
            }
            else
            {
                Console.WriteLine("Credentials are wrong");
            }
        }

        private void PromptUserRegister()
        {
            var newUser = UserHelper.GetUserFromUser();

            if (Auth.CheckIfUserExists(newUser.UserName))
            {
                Console.WriteLine("User Already exists.");
            }
            else 
            {
                Auth.Register(newUser);
                Console.WriteLine("User registered successfully!");
            }
        }

        private void PrintAllUsers()
        {
            foreach (var user in Auth.Users)
            {
                Console.WriteLine($" {user.UserName} ");
            }
        }

        

        public void HandleLoggedInCommand(LoggedInCommands loggedInCommand)
        {
            switch (loggedInCommand)
            {
                case LoggedInCommands.Logout:
                    break;
                
            }
        }

        



        public InitialCommands PromptAndGetInitialCommands()
        {
            for (int i = 0;i<NonLoggedInCommandsArray.Length; i++)
            {
                Console.WriteLine($"{i+1} -> {NonLoggedInCommandsArray[i]}");
            }
            
            int command;
            do
            {
                command = Helper.PromptAndGetPositiveInt("Pleae enter command: ");
                if(command > NonLoggedInCommandsArray.Length)
                    Console.WriteLine("Invalid command! Try Again!");

            } while (command>NonLoggedInCommandsArray.Length);

            return (InitialCommands) command;
        }


        public LoggedInCommands PromptAndGetLoggedInCommands()
        {
            for (int i = 0; i < LoggedInCommandsArray.Length; i++)
            {
                Console.WriteLine($"{i + 1} -> {LoggedInCommandsArray[i]}");
            }

            int command;
            do
            {
                command = Helper.PromptAndGetPositiveInt("Pleae enter command: ");
                if (command > LoggedInCommandsArray.Length)
                    Console.WriteLine("Invalid command! Try Again!");

            } while (command > LoggedInCommandsArray.Length);

            return (LoggedInCommands) command;
        }

        public bool IsLoggedIn()
        {
            return Auth.CurrentLogedInUser != null;
        }


    }
}
