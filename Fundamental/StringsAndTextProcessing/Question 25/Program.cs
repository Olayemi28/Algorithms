using System;

namespace Question_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintsWordInOrder("One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten.");
        }
        static void PrintsWordInOrder(string text)
        {
            char[] seperators = { ' ', ',', '.', '/', '\\', '!', ';', ':' };
            string[] split = text.ToUpper().Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(split);
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }
        }
    }
}
