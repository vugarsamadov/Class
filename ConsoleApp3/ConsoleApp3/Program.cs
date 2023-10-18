using System;
using System.Reflection;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3

            // 1234 => 4123 => 3412 => 2341
            // 312 231 123

            // 1223 => 3122 => 2312 => 2231 => 1223

            int number = 123;
            int shiftingNumber = number;
            int cursorNumber = number;
            int rightMostCursor = number % 10;
            int rightMostShifted = 0;


            int counter = 0;
            do
            {
                number /= 10;
                counter++;
            } while ((number != 0));

            bool found = false;

            int mertebe = 10;
            for (int i = 1; i < counter; i++)
                mertebe *= 10;

            while (cursorNumber != 0 && !found)
            {
                rightMostCursor = cursorNumber % 10;
                cursorNumber /= 10;
                for (int i = 1; i < counter - 1; i++)
                {
                    rightMostShifted = shiftingNumber % 10;
                    shiftingNumber /= 10;
                    shiftingNumber = shiftingNumber + rightMostShifted * mertebe;

                    if (shiftingNumber % 10 == rightMostCursor)
                    {
                        found = true;
                        break;
                    }

                }
            }

            Console.WriteLine(found);
        }
    }
}
