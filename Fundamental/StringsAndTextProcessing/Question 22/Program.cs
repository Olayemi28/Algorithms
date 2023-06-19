using System;
using System.Collections.Generic;

namespace Question_22
{
    class Program
    {
        static int count = 0;
        static Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SortAlphabetically("Learning to code is learning to create and innovate");
        }
        static void SortAlphabetically(string text)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 
                'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 
                'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] splitText = text.ToUpper().ToCharArray();
            for (int i = 0; i < alphabet.Length; i++)
            {
                char save = alphabet[i];
                for (int j = 0; j < splitText.Length; j++)
                {
                    if (alphabet[i] == splitText[j] && !(keyValuePairs.ContainsKey(alphabet[i])))
                    {
                        keyValuePairs.Add(alphabet[i], count);
                    }
                    if (alphabet[i] == splitText[j])
                    {
                        if (keyValuePairs.ContainsKey(alphabet[i]))
                        {
                            keyValuePairs[save]++;
                        }
                    }
                    if (!(keyValuePairs.ContainsKey(alphabet[i])))
                    {
                        keyValuePairs.Add(alphabet[i], count);
                    }
                }
            }
            foreach (var item in keyValuePairs)
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key.ToString()} = {item.Value}");
                }
            }
        }
    }
}
