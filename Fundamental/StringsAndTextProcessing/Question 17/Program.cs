using System;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculateInterval("29.08.2022", "27.08.2022");
        }
        static void CalculateInterval(string date1, string date2)
        {
            DateTime datetime1 = DateTime.Parse(date1);
            DateTime datetime2 = DateTime.Parse(date2);
            TimeSpan result = datetime1 - datetime2;
            Console.WriteLine($"The interval between {datetime1} and {datetime2} = {result} days inteval(s).");
        }
    }
}
