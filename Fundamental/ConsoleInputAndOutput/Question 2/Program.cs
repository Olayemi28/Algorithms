using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console the radius "r" of a circle 
            // and prints its perimeter and area.

            Console.Write("Enter a radius:");
            int radius;
            while (!(int.TryParse(Console.ReadLine(), out radius)))
            {
                Console.Write("Kindly enter a number:");
            }
            double result = Math.PI * Math.Pow(radius, 2);
            double results = 2 * Math.PI * radius;
            Console.WriteLine($"The area of a circle is {result} and result for the perimeter of a circle is {results}");
        }
    }
}
