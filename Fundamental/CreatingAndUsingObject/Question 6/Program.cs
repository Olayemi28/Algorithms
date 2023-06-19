using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which calculates the area of a triangle with the 
            // following given:
            // - three sides;
            // - side and the altitude to it;
            // - two sides and the angle between them in degrees.
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Enter 1 to use three sides to calculate the area of a triangle." +
            "\nEnter 2 to use two sides to calculate the altitude of a triangle." +
            "\nEnter 3 to calculate a triangle with two sides and angle between them.");

            int input;
            while (!(int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 3))
            {
                Console.WriteLine("Input must not less than 1 and must be greater than or equal to 3.");
            }

            if(input == 1)
            {
                Console.Write("Enter side1:");
                double side1 = double.Parse(Console.ReadLine());

                Console.Write("Enter side2:");
                double side2 = double.Parse(Console.ReadLine());

                Console.Write("Enter side3:");
                float side3 = float.Parse(Console.ReadLine());
                double result = CalculateAreaOfTriangle(side1, side2, side3);
                Console.WriteLine(result);
            }
            else if(input == 2)
            {
                Console.Write("Enter side1:");
                double side1 = double.Parse(Console.ReadLine());

                Console.Write("Enter side2:");
                double side2 = double.Parse(Console.ReadLine());
                double output = CalculateAreaOfTriangle(side1, side2);
                Console.WriteLine(output);
            }
            else if(input == 3)
            {
                Console.Write("Enter side1:");
                double side1 = double.Parse(Console.ReadLine());

                Console.Write("Enter side2:");
                double side2 = double.Parse(Console.ReadLine());

                Console.Write("Enter an angle:");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateAreaOfTriangle(side1, side2, angle));
            }
        }
        static double CalculateAreaOfTriangle(double a, double b, float c)
        {
            double P = (a + b + c) / 2;
            double pA = P - a;
            double pB = P - b;
            double pC = P - c;
            double result = P * pA * pB * pC;
            double S = Math.Sqrt(result);
            return S;
        }
        static double CalculateAreaOfTriangle(double b, double h)
        {
            double S = (b + h) / 2;
            return S;
        }
        static double CalculateAreaOfTriangle(double a, double b, double angle)
        {
            double S = (a * b * Math.Sin(angle)) / 2;
            return S;
        }
    }
}
