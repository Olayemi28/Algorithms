using System;
using System.Collections.Generic;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a given number from decimal to binary 
            // notation (numeral system).

            int reminder = 0;
            List<int> save = new List<int>();
            Console.Write("Enter a decimal number:");
            int num;
            while (!(int.TryParse(Console.ReadLine(), out num)))
            {
                Console.Write("Kindly enter a number:");
            }
            while(num > 0)
            {
                reminder = num % 2;
                save.Add(reminder);
                num = num / 2;
            } 
           for (int i = save.Count - 1; i >= 0; i--)
           {
             Console.Write(save[i]);
           }
        }
    }
}
