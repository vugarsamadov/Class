using System;

namespace October18Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            AskForInput();


        }


        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void AskForInput()
        {
            
            string command;
            int input;
            int[] array = new int[0];
            bool commandCheck = false;
            do
            {
                command = PromptAndGetString("Type yes/y to add element to array: ");
                commandCheck = command == "yes" || command == "y";
                
                if (!commandCheck)
                    break;
                
                Array.Resize(ref array, array.Length+1);

                array[array.Length-1] = PromptAndGetInt("Enter a number: "); ;
                
            } while (commandCheck);


            PrintArray(array);
        }

        static string PromptAndGetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static int PromptAndGetInt(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
                Console.WriteLine(i);
        }




    }
}
