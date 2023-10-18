using System;

namespace October18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 2, 3, 4, 5, 1, 7, 8, 9 };

            SwapMinMax(array);

            foreach (int i in array) 
                Console.Write(i+" ");

        }

        static void SwapMinMax(int[] array)
        {

            int minIndex = FindMinIndex(array);
            int maxIndex = FindMaxIndex(array);

            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp; 

        }
        static int FindMinIndex(int[] array)
        {
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
            }
            return minIndex;
        }
        
        static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }
            return maxIndex;
        }
    }
}
