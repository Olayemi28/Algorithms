using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorial = 1;
            Console.Write("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a number in factorial:");
            double num = int.Parse(Console.ReadLine());
            int i = 1;
            while(i < num)
            {
                double e;
                factorial *= num;
                num--;
                double n = Math.Pow(x, 2);
                 e = 1 + n / factorial;
                double y = Math.Pow(Math.E(e, n));
                i++;
                Console.WriteLine(e);
                Console.WriteLine(y);
            }
        }
        
    }
}
