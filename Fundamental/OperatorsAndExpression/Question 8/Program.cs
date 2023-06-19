using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for a given point {x, y} if it is within 
            // the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
            // the circle and 5 is the radius.

            Console.Write("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            int y = int.Parse(Console.ReadLine());
            int radius = 5;
            int result = (x * x) + (y * y);
            string answer = result <= radius ? $"The point {result} is inside the circle of radius {radius}" : $"The point {result} is not inside the circle of radius {radius}";
            Console.WriteLine(answer);
        }
    }
}
