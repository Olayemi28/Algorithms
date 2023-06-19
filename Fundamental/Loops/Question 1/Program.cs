using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints on the console the numbers from 1 to N. 
            // The number N should be read from the standard input.

            Console.Write("Enter a num:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N)))
            {
                Console.Write("Kindly enter a number:");
            }
            for (int a = 1; a <= N; a++)
            {
                Console.WriteLine($"N = {a}");
            }
        }
    }
}
