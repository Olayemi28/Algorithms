using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that applies bonus points to given scores in the range 
            // [1…9] by the following rules:
            // - If the score is between 1 and 3, the program multiplies it by 10.
            // - If the score is between 4 and 6, the program multiplies it by 100.
            // - If the score is between 7 and 9, the program multiplies it by 1000.
            // - If the score is 0 or more than 9, the program prints an error 
            // message.

            Console.WriteLine("Write a program that applies bonus points to given scores in the range 1...9");
            Console.Write("Enter a score:");
            int score;
            while (!(int.TryParse(Console.ReadLine(), out score)))
            {
                Console.Write("Kindly enter a number:");
            }
            int result;
            if (score >= 1 && score <= 3)
            {
                result = score * 10;
                Console.WriteLine($"Your score plus bonus points is:{result}");
            }
            else if (score >= 4 && score <= 6)
            {
                result = score * 100;
                Console.WriteLine($"Your score plus bonus points is:{result}");
            }
            else if (score >= 7 && score <= 9)
            {
                result = score * 1000;
                Console.WriteLine($"Your score plus bonus points is:{result}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
