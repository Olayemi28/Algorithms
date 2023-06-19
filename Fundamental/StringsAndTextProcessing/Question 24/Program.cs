using System;
using System.Linq;

namespace Question_24
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FindSequenceOfLetters("aaaaabbbbbcdddeeeedssaa");
        }
        static int lastIndex;
        static string save;
        static int i;
        static int j;
        static void FindSequenceOfLetters(string text)
        {
            char[] split = text.ToCharArray();
            for (i = 0; i < split.Length; i++)
            {
                for (j = i; j < split.Length; j++)
                {
                    if (split[i] != split[j])
                    {
                        save += split[i];
                        lastIndex = j;
                        i = lastIndex-1;
                        break;
                    }
                    if (j == split.Length - 1)
                    {
                        save += split[j];
                        break;
                    }
                }
            }
            Console.WriteLine(save);
        }

        
    }
}
