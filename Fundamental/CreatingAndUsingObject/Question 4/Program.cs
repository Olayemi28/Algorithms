using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints on the standard output the count of days, 
            // hours, and minutes, which have passes since the computer is 
            // started until the moment of the program execution. For the 
            // implementation use the class Environment.
            CountTimeTillNow();
        }
        static void CountTimeTillNow()
        {
            int startingTime = Environment.TickCount;
            double days = startingTime / 86400000;
            double remainderAfterDays = startingTime - (days * 86400000);
            double hours = Math.Floor(remainderAfterDays / 3600000);
            double remainderAfterHours = remainderAfterDays - (hours * 3600000);
            double minutes = Math.Floor(remainderAfterHours / 60000);
            double remainderAfterMinutes = remainderAfterHours - (minutes * 60000);
            double seconds = Math.Floor(remainderAfterMinutes / 1000);
            double remainderAfterSeconds = remainderAfterMinutes - (seconds * 1000);
            double milliseconds = remainderAfterSeconds;
            Console.WriteLine($"The program execution time uptil now: {days} days, " +  
            $"{hours} hours, {minutes} minutes, {seconds} seconds, {milliseconds} milliseconds.");
        }
    }
}
