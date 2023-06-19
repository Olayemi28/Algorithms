using System;

namespace Question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a <= 40; a++)
            {
                double result = Math.Pow(2, a);
                Console.WriteLine(result);
            }
        }
    }
}
