using System;
using System.Diagnostics.Tracing;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string word = "Salam";
            //char targetLetter = 'l';
            //bool isFound = false;

            //for (int i = 0; i < word.Length; i++) 
            //{
            //    if (word[i] == targetLetter)
            //    {
            //        isFound = true;
            //        break;
            //    }
            //}
            ////Console.WriteLine(isFound);


            //string sentence = "Salam sabahiniz xeyir";
            ////string sentence = "salamlar sabahiniz semereli kecsin";
            //string targetWord = "sabahiniz x";

            //bool insideWord = false;
            //int targetWordIndx = 0;


            //for (int i = 0;i < sentence.Length;i++) 
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        insideWord = true;
            //        continue;
            //    }
            //    if ((targetWordIndx == targetWord.Length))
            //        break;
            //    else if (sentence[i] == targetWord[targetWordIndx++] && insideWord == true)
            //        continue;

            //    targetWordIndx = 0;
            //    insideWord = false;
            //}

            //if(targetWordIndx == targetWord.Length)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);

            //string word = " salam ";
            //string trimmedWord = "";

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] != ' ')
            //        trimmedWord += word[i];
            //}

            //Console.WriteLine(trimmedWord);


            //Console.Write("Enter begining of the range: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter end of the range: ");
            //int m = Convert.ToInt32(Console.ReadLine());

            //for (int i = n; i <= m; i++)
            //{
            //    if(i>0)
            //        Console.WriteLine(string.Format("Musbet {0} Menfi {1}", i, i*-1));
            //    else if(i<0)
            //        Console.WriteLine(string.Format("Menfi {0} Musbet {1}", i, i*-1));
            //    else
            //        Console.WriteLine(i);

            //}

            //Console.Write("Enter word: ");
            //string sample = Console.ReadLine();
            //Console.Write("Reversed: ");
            //for (int i = sample.Length-1; -1 < i; i--) 
            //{
            //    Console.Write(sample[i]);
            //}


            int[] array = {6,2,3,3,4,5,3,6,7,6,6 };

            for(int j = 0; j< array.Length; j++)
            {

            for (int i = 1; i < array.Length; i++) 
            {
                if (array[i] < array[i-1])
                {
                    int temp = array[i];
                    array[i] = array[i-1];
                    array[i-1] = temp;
                }
            }
            }
            
            foreach(var a in array)
                Console.WriteLine(a);
        }
    }
}
