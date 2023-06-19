using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 0;
            double factorial = 1;
            Console.Write("Enter a number in factorial:");
            double num = int.Parse(Console.ReadLine());
            for(int a = 1; a <= num; a++)
            {
                factorial *= num;
                num--;
                e = 1 + (1 / num);
                Console.WriteLine($" e = {e}");
            }
            
                
            
        }
    }
}
