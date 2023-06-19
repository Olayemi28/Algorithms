using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a Boolean expression that checks if the bit on position p in the 
            // integer v has the value 1. Example v=5, p=1 -> false.

            Console.Write("Enter v:");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter p:");
            double p = double.Parse(Console.ReadLine());
            string bin = Convert.ToString(v, 2);
            int position = (int)(Math.Pow(2, p));
            Console.WriteLine(bin);
            bool bit3 = (v & position) != 0;
            Console.WriteLine(bit3);
        }
    }
}
