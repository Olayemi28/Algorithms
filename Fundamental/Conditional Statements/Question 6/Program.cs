using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that gets the coefficients a, b and c of a quadratic 
            // equation: ax
            // 2 + bx + c, calculates and prints its real roots (if they exist). 
            // Quadratic equations may have 0, 1 or 2 real roots.

            Console.Write("Enter the coefficient of a:");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)))
            {
                Console.Write("Kindly enter number:");
            }
            Console.Write("Enter the coefficient of b:");
            int b;
            while (!(int.TryParse(Console.ReadLine(), out b)))
            {
                Console.Write("Kindly enter number:");
            }
            Console.Write("Enter the coefficient of c:");
            int c;
            while (!(int.TryParse(Console.ReadLine(), out c)))
            {
                Console.Write("Kindly enter number:");
            }
            int d = (b * b) - (4 * a * c);
            double x = 0;
            if (d == 0)
            {
                x = -b / (2 * a);
            }
            if (d > 0)
            {
                x = -b + Math.Sqrt(b * b - 4 * a * c) / 2 * a;
            }
            if (d < 0)
            {
                Console.WriteLine("The equation has no roots");
            }
            Console.WriteLine($"It\'s real root is {x}");

        }
    }
}
