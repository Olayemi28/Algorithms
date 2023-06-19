using System;
using System.Collections.Generic;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads an integer number n from the console and 
            // prints all numbers in the range [1…n], each on a separate line.

            Console.Write("Enter the number of time you want your code to run:");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.Write("Kindly enter a number:");
            }
            
            int num = 0;
            while(num <= n)
            {
                Console.WriteLine(num);
                num++;
            }
            
        }
       
    }
}
