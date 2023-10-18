using System;
using System.Reflection;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3

            // 1234 => 4123 => 3412 => 2341

            int number = 1234;
            int temporary = number;

            int rightMost = number % 10;
            int teklik;

            int counter = 0;
            do
            {
                number /= 10;
                counter++;
            } while ((number != 0));

            for(int i =1; i < counter-1; i++)
            {
                teklik = temporary % 10;
                temporary /= 10;
                temporary += teklik * counter;
                Console.WriteLine(temporary);
            }







            // 4

            //string name = "Vugar";
            //string surname = "Samadov";

            //Console.WriteLine(surname[0] + ". " + name);

            // 5

            //int[] array = { 1, -2, 3, -7 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //        array[i] = array[i] * -1;
            //}


            // 2

            //int[] numbers = {5,3,2,9,6,1,4,8,7};
            //int minIndex = 0, maxIndex = 0;
            
            //for(int i = 0;i<numbers.Length;i++) 
            //{
            //    if (numbers[minIndex] > numbers[i])
            //    {
            //        minIndex = i;
            //    }
            //    if (numbers[maxIndex] < numbers[i])
            //    {
            //        maxIndex = i;
            //    }
            //}
            //int temp = numbers[minIndex];
            //numbers[minIndex] = numbers[maxIndex];
            //numbers[maxIndex] = temp;
            
        }
    }
}
