using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that looks for a given integer if its third digit (right 
            // to left) is 7.

            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int num = (number / 100);
            int m = num % 10;
            if(m == 7)
            {
                Console.WriteLine($"{m} in {number} is the original number");
            }
            else
            {
                Console.WriteLine($"{m} in {number} is not in the third digit position");
            }
            Console.ReadLine();
        }
    }
}
