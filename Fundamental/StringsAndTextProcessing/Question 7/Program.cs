using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShorterCompliments("Learning to code is learning to create and innovate");
        }
        static void ShorterCompliments(string text)
        {
          string result = text.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}
