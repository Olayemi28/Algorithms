using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that calculates N!/K! for given N and K (1<K<N).

            Console.Write("K = ");
            int K;
            while (!(int.TryParse(Console.ReadLine(), out K) && K > 1))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("N = ");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N) && N > K))
            {
                Console.Write("Kindly enter a number:");
            }
            int factorial = 1;
            for(int i = N; i > K; i--)
            {
                factorial *= i;
            }
            Console.Write($"The factorial of {N}!/{K}! = {factorial}");
            
            




















        }
    }
}
