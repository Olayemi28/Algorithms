using System;
using System.Collections.Generic;

namespace Question_23
{
    class Program
    {
        static int count;
        static int result;
        static Dictionary<string, int> words = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumberOfWordsAlphabetically("Father Femi Fried Fish For Five Friends Father");
        }
        static void PrintNumberOfWordsAlphabetically(string text)
        {
            char[] seperators = { ' ', ',', '.', '/', '\\', '!', ';', ':' };
            string[] split = text.ToUpper().Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(split);
            foreach (var item in split)
            {
                if (!(words.ContainsKey(item)))
                {
                    words.Add(item, count = 1);
                }
                else
                {
                    words[item]++;
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
