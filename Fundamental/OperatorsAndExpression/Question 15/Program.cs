using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
           //* Write a program that exchanges the values of the bits on positions 
           //3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
           //integer.

            Console.Write("Enter a num:");
            int num = int.Parse(Console.ReadLine());
            int bit3 = (num >> 3) & 1;
            int bit24 = (num >> 24) & 1;
            num = num & (~(1 << 24)) | (bit3 << 24);
            num = num & (~(1 << 3)) | (bit24 << 3);

        }
    }
}
