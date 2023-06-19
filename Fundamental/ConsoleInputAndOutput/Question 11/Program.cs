using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints on the console the first 100 numbers in the 
            // Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

            ulong a = 0, b = 1, c = 0;
            for(ulong i = 0; i < 100; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(i == 0 ? $"{0}\n{1}" : $"{c}");
            }
           
            
        }
    }
}
