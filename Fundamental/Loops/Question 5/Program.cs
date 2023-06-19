using System;
using System.Numerics;
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console number N and print the sum 
            // of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
            // 13, 21, 34, 55, 89, 144, 233, 377, …

            int a = 0;
            int b = 1;
            int c = 0;
            BigInteger sum = 1;
            Console.Write("Enter a number:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write($"{a}, {b}");
            for (int i = 0; i < N; i++)
            {
                c = a + b;
                a = b;
                b = c;
               sum += c;
               Console.Write($", {c}");
            }
           
            Console.WriteLine($".The sum of the {N}th term of the fibonacci = {sum}");
        }
    }
}
