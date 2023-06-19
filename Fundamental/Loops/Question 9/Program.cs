using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("N = ");
           int N;
           while (!(int.TryParse(Console.ReadLine(), out N)))
           {
               Console.Write("Kindly enter a number:");
           }
           Console.Write("X = ");
           int X;
           while (!(int.TryParse(Console.ReadLine(), out X)))
           {
               Console.Write("Kindly enter a number:");
           }
           double factorial = 1;
           double sum = 1;
           double finalResult = 1;
           for (int i = 1; i <= N; i++)
           {
               factorial *= i;
               double power = Math.Pow(X, i);
               double result = factorial / power;
               finalResult = sum += result;
           }
           Console.Write($"The sum of {N} and {X} = {finalResult}");
        }
    }
}
