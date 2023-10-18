using System;
using System.Data;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            int[] numbers = { -91, -44, 7, 0,-27,  91, -97 };

//            // 1                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               `0.0.147`    
            
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }
//            Console.WriteLine();

//            // 2 

//            int negativeCounter = 0;

//            for (int i = 0;i < numbers.Length; i++) 
//            {
//                if (numbers[i] < 0)
//                    negativeCounter++;
//            }

//            Console.WriteLine("Negative number count "+negativeCounter);

//            // 3

//            float sum = 0;

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                sum += numbers[i];
//            }
//            float mean = sum / numbers.Length;
            
//            Console.WriteLine("Mean is "+mean);

//            // 4

//            int maxNumber = numbers[0];
//            int minNumber = numbers[0];

//            for (int i = 1; i < numbers.Length; i++) 
//            {
//                if(maxNumber < numbers[i])
//                    maxNumber = numbers[i];
//                if(minNumber > numbers[i])
//                    minNumber = numbers[i];
//            }

//            Console.WriteLine("Sum of max and min: "+(maxNumber+minNumber));

//            // 5
//            // { -91, -44, 7, 0, -27, 91, 91, -97 };


//            //maxNumber = numbers[0];
//            //int secMaxNumber = numbers[0];

//            //for (int i = 1; i < numbers.Length; i++)
//            //{
//            //    if (maxNumber < numbers[i])
//            //    {
//            //        maxNumber = numbers[i];
//            //        secMaxNumber = numbers[i];
//            //    }
//            //    else if (secMaxNumber < numbers[i] && secMaxNumber != maxNumber)
//            //        secMaxNumber = numbers[i];

//            //}
//            //Console.WriteLine(secMaxNumber);

            string command = null;
            do
            {
                Console.WriteLine("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                
                if (number >= 10 && number <= 20)
                {
                    if (number%2==0)
                        Console.WriteLine(number+" is even.");
                    else
                        Console.WriteLine(number +" is not even.");
                }
                else 
                    Console.WriteLine("Input is not in range of 10-20!");

                Console.WriteLine("Type Y/y/yes to try again");
                command = Console.ReadLine();

            } while (command == "Y" || command == "yes" || command == "y");


        }
    }
}
