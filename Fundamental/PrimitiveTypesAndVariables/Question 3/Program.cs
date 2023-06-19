using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
          // Write a program, which compares correctly two real numbers with 
           // accuracy at least 0.000001.

           Console.Write("Enter a number:");
           double num1 = double.Parse(Console.ReadLine());
           Console.Write("Enter another number:");
           double num2 = double.Parse(Console.ReadLine());
           bool equal = Math.Abs(num1 - num2) < 0.000001;
           Console.WriteLine(equal);
           
        }
    }
}
