using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads five integer numbers and prints their 
            // sum. If an invalid number is entered the program should prompt the user 
            // to enter another number.
            int sum = 0;
            for (int i = 1; i <= 5; i++)
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
