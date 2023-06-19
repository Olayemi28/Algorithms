using System;
using System.Collections.Generic;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a given number from binary to decimal 
            // notation.

            int reminder = 0;
            int placeValue = 1;
            int save = 0;
            int decimalValue = 0;
            Console.Write("Enter a binary number:");
            int binary;
            while (!(int.TryParse(Console.ReadLine(), out binary)))
            {
                Console.Write("Kindly enter a number:");
            }
            while(binary > 0)
            {
                reminder = binary % 10;
                decimalValue = reminder * placeValue;
                save += decimalValue;
                placeValue *= 2;
                binary /= 10;
            }
           Console.WriteLine(save);
        }
    }
}
