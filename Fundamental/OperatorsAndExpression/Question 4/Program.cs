using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks whether the third bit in a given integer 
            // is 1 or 0.

            // Using Bitwise AND Operator
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            bool result = (num & 8) != 0;
            Console.WriteLine(result);

            //Using Bitwise (bit shift right) Operator
            Console.Write("Enter  number:");
            int numb = int.Parse(Console.ReadLine());
            bool isThirdBit = ((numb >> 3) & 1) == 1 ? true : false;
            Console.WriteLine(isThirdBit);
        }
    }
}
