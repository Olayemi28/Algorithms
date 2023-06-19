using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int count = 0;
            int number = random.Next(100, 1000);
            Console.WriteLine(number);
            Console.Write("enter a number:");
            int num = int.Parse(Console.ReadLine());
            if (num == number)
            {
                Console.WriteLine("congratulations!you have been awarded with the sum of $10,000");
            }
            string x = number.ToString();
            string y = num.ToString();
            for (int a = 0; a < x.Length; a++)
            {
                for (int b = 0; b < y.Length; b++)
                {
                    if (x[a] == y[b])
                    {
                        count++;
                    }
                }
            }
            if (count == 3)
            {
                Console.WriteLine("congratulations!you have awarded with the sum of $3,000");
            }
            else if (count == 1)
            {
                Console.WriteLine("You have been awarded with the sum of $1000");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
