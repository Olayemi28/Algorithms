using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the first 100 members of the sequence 2, -
            // 3, 4, -5, 6, -7, 8.

            for(int i = 2; i <=100; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine($"-{i}");
                }
               else
               {
                    Console.WriteLine(i);
               }
            }
        }
    }
}
