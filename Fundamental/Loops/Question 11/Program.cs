using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates with how many zeroes the factorial of 
            // a given number ends. Examples:
            // N = 10 -> N! = 3628800 -> 2
            // N = 20 -> N! = 2432902008176640000 -> 4

            Console.WriteLine("Enter a number for N!:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N)))
            {
                Console.Write("Kindly enter a number:");
            }
            int Zero = 0;
            decimal factorial = 1;
            for (int a = N; a > 0; a--)
            {
               factorial *= a;
            }
            Console.WriteLine($"{N}! = {factorial}");
            while (factorial % 10 == 0)
            {
                factorial /= 10;
                Zero++;
            }
            Console.WriteLine($"The count of zero in {N}! = {Zero}");
        }
    }
}
