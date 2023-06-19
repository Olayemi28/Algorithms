using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a series of integers and 
            // prints the smallest and largest of them.

            int max = int.MinValue;
            int min = int.MaxValue;
            for (int a = 0; a <= 10; a++)
            {
                Console.Write("Enter a number:");
                int num = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"The biggest number is {max} while the smallest is {min}");

        }
    }
}
