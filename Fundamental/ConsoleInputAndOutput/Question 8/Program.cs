using System;
using System.Collections.Generic;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum = int.MinValue;
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a number:");
                int number;
                while (!(int.TryParse(Console.ReadLine(), out number)))
                {
                    Console.Write("Kindly enter a number:");
                }
                numbers.Add(number);
            }
            foreach (var item in numbers)
            {
                if(item > maximum)
                {
                    maximum = item;
                }
            }
            Console.WriteLine($"The biggest number is {maximum}");
        }
    }
}
