using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates the sum (with precision of 0.001) of 
            // the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …

            double n = 0;
            double m = 0;
            double sum = 0;
            Console.Write("Enter a number:");
            int num;
            while (!(int.TryParse(Console.ReadLine(), out num)))
            {
               Console.Write("Kindly enter a number:");
            }
            for (double i = 2; i <= num; i++)
            {
                if(i % 2 == 0)
                {
                    n += (1 / i);
                }
                else
                {
                    m += (-1 / i);
                }
                sum = 1 + n + m;
            }
            Console.WriteLine("{0:F3}", sum);
        }
    }
}
