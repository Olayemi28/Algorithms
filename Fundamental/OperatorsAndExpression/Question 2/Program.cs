using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a Boolean expression that checks whether a given integer is 
            // divisible by both 5 and 7, without a remainder.


            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if(number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine($"{number} is divisible by 5 and 7");
            }
            else if(number % 5 == 0 && number % 7 != 0)
            {
                Console.WriteLine($"{number} can only be divided by 5 and not 7");
            }
            else if(number % 5 != 0 && number % 7 == 0)
            {
                Console.WriteLine($"{number} is only divisible by 7 and not 5");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
       }
    }
}
