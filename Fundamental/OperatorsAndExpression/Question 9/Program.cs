using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for given point {x, y} if it is within the 
            // circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
            // Clarification: for the rectangle the lower left and the upper right corners 
            // are given.

            Console.Write("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            int y = int.Parse(Console.ReadLine());
            int result = (x * x) + (y * y);
            string isInsideCircle = result <= 5 ? $"The point {result} is within the circle" : $"The point {result} is outside the circle";
            string isOutsideRectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? $"The point O({x},{y}) is outside rectangle (-1, 1), (5, 5)" : $"The point O({x},{y}) is inside rectangle (-1, 1), (5, 5)";
            Console.WriteLine(isInsideCircle);
            Console.WriteLine(isOutsideRectangle);
        }
    }
}
