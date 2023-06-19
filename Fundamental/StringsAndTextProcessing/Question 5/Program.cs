using System;

namespace Question_5
{
    class Program
    {
        static int count;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FindOccurence("We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.");
        }
        static void FindOccurence(string text)
        {
            string word = "IN";
            int index = text.ToUpper().IndexOf(word);
            while (index != -1)
            {
                count++;
                index = text.ToUpper().IndexOf(word, index);
                index = text.ToUpper().IndexOf(word, index + 1);
            }
            Console.WriteLine($"{word} occurs {count} time(s)");
        }
    }
}
