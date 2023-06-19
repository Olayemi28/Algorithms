using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N) && N >= 0))
            {
                Console.Write("Kindly enter a number greater than 0:");
            }
            decimal factorial = 1;
            decimal n2factorial = 1;
            int add1ToFactorial = N + 1;
            decimal factorial2 = 1;
            decimal multiply2Factorial = 1;
            int multiplyFactorial = 2 * N;
            decimal result = 1;
            for (int i = N; i > 0; i--)
            {
                factorial *= i;
            }
            for (int j = add1ToFactorial; j > 0; j--)
            {
                factorial2 *= j;
            }
            for (int k = multiplyFactorial; k > 0; k--)
            {
                n2factorial *= k;
            }
            multiply2Factorial = factorial2 * factorial;
            result = n2factorial / multiply2Factorial;
            Console.WriteLine($"The result of 2({N}!)/({N} + 1! {N}!) = {result}");
        }
    }
}
