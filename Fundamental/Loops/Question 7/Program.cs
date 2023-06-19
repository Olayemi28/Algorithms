using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates N!*K!/(N-K)! for given N and K 
            // (1<K<N).

            Console.Write("K = ");
            int K;
            while (!(int.TryParse(Console.ReadLine(), out K) && K > 1))
            {
                Console.Write("Kindly enter a number graeter than 1:");
            }
            Console.Write("N = ");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N) && N > K))
            {
                Console.Write("Kindly enter a number greater than K:");
            }
            decimal nfactorial = 1;
            decimal kfactorial = 1;
            decimal tFactorial = 1;
            decimal nkFactorial = 1;
            decimal result = 1;
            int nk = N - K;
            for (int i = N; i > 0; i--)
            {
                nfactorial *= i;
            }
            for (int j = K; j > 0; j--)
            {
                kfactorial *= j;
            }
            for (int k = nk; k > 0; k--)
            {
                nkFactorial *= k;
            }
            tFactorial = nfactorial * kfactorial;
            result = tFactorial / nkFactorial;
            Console.WriteLine($"The factorial of {N}!*{K}!/({N}-{K})! = {result}");
        }
    }
}
