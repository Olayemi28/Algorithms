using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that calculates the area of a trapezoid by given 
            // sides a, b and height h.

            //The formula for trapezoid surface is: S = (a + b) * h / 2.
            Console.Write("Enter the first number:");
            int sides1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int sides2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            int height = int.Parse(Console.ReadLine());
            
            int result = (sides1 + sides2) * height / 2;
            Console.WriteLine(result);
        }
    }
}
