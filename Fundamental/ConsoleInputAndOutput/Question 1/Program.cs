using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console three numbers of type int
            // and prints their sum.

            int sum = 0;
            for(int i = 1; i <= 3; i++)
            {
                Console.Write("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
