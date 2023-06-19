using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which reads from the console a year and checks if it is 
            // a leap year.

            Console.Write("Enter any year of your choice: ");
            int year = int.Parse(Console.ReadLine());
            CalculateLeapYear(year);
        }
        static void CalculateLeapYear(int year)
        {
            bool result = DateTime.IsLeapYear(year);
            if (result == true)
            {
                Console.Write($"{year} is a leap year.");
            }
            else
            {
                Console.Write($"{year} is not a leap year.");
            }
        }
    }
}
