using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int minRange = 2;
        int maxRange = 56;

        int count = 0;

        for (int i = minRange; i <= maxRange; i++)
        {
            if (i % 12 == 0)
            {
                count++;
            }
        }


        Console.WriteLine(count);

    }
}
