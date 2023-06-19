using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the greatest of given 5 numbers.

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
                Console.Write("Enter thidr number:");
                int num3;
                while (!(int.TryParse(Console.ReadLine(), out num3)))
                {
                    Console.Write("Kindly enter number:");
                }
                Console.Write("Enter fourth number:");
                int num4;
                while (!(int.TryParse(Console.ReadLine(), out num4)))
                {
                    Console.Write("Kindly enter number:");
                }
                Console.Write("Enter fifth number:");
                int num5;
                while (!(int.TryParse(Console.ReadLine(), out num5)))
                {
                    Console.Write("Kindly enter number:");
                }
                if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
                {
                    Console.WriteLine($"The greatest number is {num1}");
                }
                if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
                {
                    Console.WriteLine($"The greatest number is {num2}");
                }


                if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
                {
                    Console.WriteLine($"The greatest number is {num3}");
                }


                if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
                {
                    Console.WriteLine($"The greatest number is {num4}");
                }


                if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
                {
                    Console.WriteLine($"The greatest number is {num5}");
                }
        }
    }
}
