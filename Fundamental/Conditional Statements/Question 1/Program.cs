using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an if-statement that takes two integer variables and exchanges
            // their values if the first one is greater than the second one.

            Console.Write("Enter first number:");
            int num1;
            while (!(int.TryParse(Console.ReadLine(), out num1)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter second number:");
            int num2;
            while (!(int.TryParse(Console.ReadLine(), out num2)))
            {
                Console.Write("Kindly enter a number:");
            }
            if (num1 > num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;
                Console.WriteLine($"By swapping Num1 to Num2,the new value for Num1 = {num1} and Num2 = {num2}");
            }
            else
            {
                Console.WriteLine($"Num1 = {num1} and Num2 = {num2}");
            }

        }
    }
}
