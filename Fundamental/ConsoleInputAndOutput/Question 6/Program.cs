using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads two numbers from the console and prints the 
            // greater of them. Solve the problem without using conditional 
            // statements.

           
            Console.Write("Enter the first number:");
            int num1;
            while (!(int.TryParse(Console.ReadLine(), out num1)))
            {
                Console.Write("Kindly enter a number");
            }
            Console.Write("Enter the second number:");
            int num2;
            while (!(int.TryParse(Console.ReadLine(), out num2)))
            {
                Console.Write("Kindly enter a number");
            }
            int maximum = Math.Max(num1, num2);
            int minimum = Math.Min(num1, num2);
            Console.WriteLine("The mininum number is {0} and the maximum number is {1}", minimum, maximum);
        }
    }
}
