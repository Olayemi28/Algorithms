using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // The gravitational field of the Moon is approximately 17% of that on the 
            // Earth. Write a program that calculates the weight of a man on the 
            // moon by a given weight on the Earth.

            Console.Write("Enter number:");
            double weightOfMan = double.Parse(Console.ReadLine());
            double weightOfMoonOnEarth = 0.17;
            double result = weightOfMan * weightOfMoonOnEarth;
            Console.WriteLine("The weight of a man on the moon by a given weight on the Earth " + result);
        }
    }
}
