using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads an integer number n from the console. After 
            // that reads n numbers from the console and prints their sum.

            Console.Write("Enter the number of time you want your code to run:");
            int num;
            while (!(int.TryParse(Console.ReadLine(), out num)))
            {
                Console.Write("Kindly enter a number:");
            }
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Enter a number:");
                int number;
                while (!(int.TryParse(Console.ReadLine(), out number)))
                {
                   Console.Write("Kindly enter a number:");
                }
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
