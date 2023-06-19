using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints on the console the numbers from 1 to N, 
            // which are not divisible by 3 and 7 simultaneously. The number N 
            // should be read from the standard input.

            Console.Write("enter a num:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N)))
            {
                Console.Write("Kindly enter a number:");
            }
            for (int a = 1; a < N; a++)
            {
                if (a % 3 != 0 && a % 7 != 0)
                {
                    Console.WriteLine("N = {0}", a);
                }

            }

        }
    }
}
