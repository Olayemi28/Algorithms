using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that, depending on the user’s choice, inputs int, double
            // or string variable. If the variable is int or double, the program 
            // increases it by 1. If the variable is a string, the program appends "*" at 
            // the end. Print the result at the console. Use switch statement.

            Console.Write("Enter an input:");
            int input;
            while (!(int.TryParse(Console.ReadLine(), out input)))
            {
                Console.Write("Kindly enter a number:");
            }
            int sum;
            double numb;
            string word;
            string ass = "*";
            switch (input)
            {
                case 0:
                    Console.Write("Enter a num:");
                    int num = int.Parse(Console.ReadLine());
                    sum = num + 1;
                    Console.WriteLine($"{sum} gives an int");
                    break;
                case 1:
                    Console.Write("Enter a num:");
                    double K = double.Parse(Console.ReadLine());
                    numb = K + 1;
                    Console.WriteLine($"{numb} gives a double");
                    break;
                case 2:
                    Console.Write("Enter a word:");
                    string w = Console.ReadLine();
                    word = w + ass;
                    Console.WriteLine($"{word} gives a string");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
