using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in factorial:");
            int product = int.Parse(Console.ReadLine());
            for (int a = 1; a < 5; a++)
            {
                product *= a;
                Console.WriteLine($"{a}               {product}");
            }
        }
    }
}
