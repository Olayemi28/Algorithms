using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks whether an integer is odd or even.

                        //Using Conditional Statement
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");
            }
            Console.ReadLine();

                         //Using Tenary Operator
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine()); 
            string result = num % 2 == 0 ?  $"{num} is an even number" : $"{num} is an odd number";
            Console.WriteLine(result);
        }
    }
}
