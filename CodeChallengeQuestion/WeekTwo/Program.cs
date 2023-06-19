using System;

namespace SecondWeekCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
             
        }
        public static int findDigits(int n)
        {
            int count = 0;
            int num = n;
            while (num != 0)
            {
                int a = num % 10;
                num /= 10;
                if(a > 0 && n % a == 0)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
