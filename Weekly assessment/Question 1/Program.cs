using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] days = { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday", "friday" };

            Console.Write("Enter a year:");
            int year = int.Parse(Console.ReadLine());
            int j = year / 100;
            int k = year % 100;
            Console.Write("Enter a month from 1-12:");
            int m = int.Parse(Console.ReadLine());
            if (m == 1)
            {
                m = 13;
            }
            if (m == 2)
            {
                m = 14;
            }
            Console.Write("Enter the days of the month from 1-31:");
            int q = int.Parse(Console.ReadLine());
            int h1 = (26 * (m + 1)) / 10;
            int h2 = k / 4;
            int h3 = j / 4;
            int h4 = 5 * j;
            int h = (q + h1 + h2 + h3 + h4);
            for (int i = 0; i < days.Length; i++)
            {
                if (h == i)
                {
                    Console.WriteLine($"{days[h]} {q} {m} {year}");
                }
            }

        }
    }
}
