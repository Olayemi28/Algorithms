using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints three numbers in three virtual columns
            // on the console. Each column should have a width of 10 characters and 
            // the numbers should be left aligned. The first number should be an 
            // integer in hexadecimal; the second should be fractional positive; and 
            // the third – a negative fraction. The last two numbers have to be 
            // rounded to the second decimal place.

            Console.Write("Enter an hexadecimal number:");
            int hexadecimal = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive fractional number:");
            double positiveFraction = double.Parse(Console.ReadLine());
            Console.Write("Enter a negative fractional number:");
            double negativeFraction = double.Parse(Console.ReadLine());
            Console.WriteLine("|0x{0, -8:x}|", hexadecimal);
            Console.WriteLine("|{0, -10:f2}|", positiveFraction);
            Console.WriteLine("|{0, -10:f2}|", negativeFraction);
        }
    }
}
