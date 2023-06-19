using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a num:");
            int numbre = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (numbre > 1 && numbre < 100)
            {
                for (int i = 2; i < (numbre / 2); i++)
                {
                    if (numbre % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine($"{numbre} is not a prime number");
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write($"{numbre} is a prime number");
                }
            }
            
        }
    }
}
