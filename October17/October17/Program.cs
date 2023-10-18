using System;

namespace October17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 birlesdirmek
            var array1 = new int[] {1,2,3,4,5 };
            var array2 = new int[] {1,2,3,4,5 };

            foreach (var i in Concat(array1,array2)) 
            {
                Console.WriteLine(i);
            }
            // 2 ededi orta

            Console.WriteLine(Mean(array1));

            // 3 Min 

            Console.WriteLine(Min(array1));

            // 4

            Console.WriteLine(MultiplyMinMax(array1));

            // 5 power

            int basee = 2;
            int exponent = 3;

            Console.WriteLine(2+"^"+3+" = "+Power(2,3));

            test( 4);

        }


        static void test(int a)
        {
            Console.WriteLine(a);
        }
        static void test(int c, int b = 6)
        {
            Console.WriteLine(c + "" + b);
        }


        static float Mean(int[] array)
        {
            return Sum(array) / array.Length;
        }
        static int Sum(int[] array)
        {
            int sum = 0;
            foreach (var i in array) 
            {
                sum += i;
            }
            return sum;
        }

        static int[] Concat(int[] array1,params int[] array2)
        {
            int[] result = new int[array1.Length+array2.Length];

            for (int i = 0, j=0; i < array1.Length+array2.Length; i++) 
            {
                if (i >= array1.Length)
                    result[i] = array2[j++];
                else
                    result[i] = array1[i];
            }
            return result;
        }

        static int Min(int[] array)
        {
            int currentMin = array[0];
            foreach (var i in array)
            {
                if(currentMin>i)
                    currentMin = i;
            }
            return currentMin;
        }

        static int Max(int[] array)
        {
            int currentMax = array[0];
            foreach (var i in array)
            {
                if (currentMax < i)
                    currentMax = i;
            }
            return currentMax;
        }

        static int MultiplyMinMax(int[] array)
        {
            return Min(array) * Max(array);
        }
        
        static int Power(int basee, int exponent)
        {
            int result = 1;
            do
                result *= basee;
            while (--exponent > 0);

            return result;
        }

    }
}
