using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the biggest of three integers, using nested 
            // if statements.
            int max = 0;
            int med = 0;
            int min = 0;

            Console.Write("Enter first number:");
            int num1;
            while (!(int.TryParse(Console.ReadLine(), out num1)))
            {
                Console.Write("Kindly enter number:");
            }
            Console.Write("Enter second number:");
            int num2;
            while (!(int.TryParse(Console.ReadLine(), out num2)))
            {
                Console.Write("Kindly enter number:");
            }
            Console.Write("Enter third number:");
            int num3;
            while (!(int.TryParse(Console.ReadLine(), out num3)))
            {
                Console.Write("Kindly enter number:");
            }
            if (num1 > num2 && num2 > num3)
            {
                max = num1;
                med = num2;
                min = num3;
            }
            if (num1 > num3 && num3 > num2)
            {
                max = num1;
                med = num3;
                min = num2;
            }
            if (num2 > num1 && num1 > num3)
            {
                max = num2;
                med = num1;
                min = num3;
            }
            if (num2 > num3 && num3 > num1)
            {
                max = num2;
                med = num3;
                min = num1;
            }
            if (num3 > num2 && num2 > num1)
            {
                max = num3;
                med = num2;
                min = num1;
            }
            if (num3 > num1 && num1 > num2)
            {
                max = num3;
                med = num1;
                min = num2;
            }
            Console.WriteLine($"The biggest of the three numbers is {max}");

        }
    }
}
