using System;
using System.Collections.Generic;
namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are given a number n and a position p. Write a sequence of 
            // operations that prints the value of the bit on the position p in the 
            // number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
            // p=6 -> 0

            Console.Write("Enter a num:");
            int dec = int.Parse(Console.ReadLine());
             string bin = Convert.ToString(dec, 2);
             Console.WriteLine(bin);
             int bit3 = (dec & 6);
             bool result = bit3 == 0 ? false : true;
             Console.WriteLine(result);


        }
    }
}
