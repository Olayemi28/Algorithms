using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which by given two sides finds the hypotenuse of a 
            // right triangle. Implement entering of the lengths of the sides from the
            // standard input, and for the calculation of the hypotenuse use methods of 
            // the class Math.

            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            double result = AreaOfTriangle(a, b);
            Console.WriteLine(result);
        }
        static double AreaOfTriangle(double a, double b)
        {
            double output = Math.Pow(a, 2) + Math.Pow(b, 2);
            double c = Math.Sqrt(output);
            return c;
        }
    }
}
