using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console two integer numbers (int)
            // and prints how many numbers between them exist, such that the 
            // remainder of their division by 5 is 0. Example: in the range (14, 25) 
            // there are 3 such numbers: 15, 20 and 25.

            Console.Write("Enter a number:");
            int small;
            while (!(int.TryParse(Console.ReadLine(), out small)))
            {
                Console.Write("Kindly enter a number:");
            }

            Console.Write("Enter another number:");
            int big;
            while (!(int.TryParse(Console.ReadLine(), out big) && small < big))
            {
                Console.Write("Kindly enter a bigger number:");
            }
            bool playOn = true;
            int count = 0;
            if (playOn)
            {
                for (int i = small; i <= big; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.Write($"{i},");
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            if (count == (big - small + 1))
            {
                Console.WriteLine($"The number {small} and {big} cannot be divisible by 5");
            }
        }
    }
}
