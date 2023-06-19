using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints, on the console which day of the week is 
            // today.
            PrintWeek();
        }
        static void PrintWeek()
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }
    }
}
