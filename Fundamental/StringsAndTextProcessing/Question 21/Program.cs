using System;

namespace Question_21
{
    class Program
    {
        static string reversed;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palindrome("Wow! Mallam Abba and Madam Lawal are in Lamal for noon Exe meeting.");
        }
        static void Palindrome(string text)
        {
            char[] seperators = { ' ', ',', '.', ';', ':','!','/','\\' };
            string[] palindrome = text.ToUpper().Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < palindrome.Length; i++)
            {
                char[] reverse =  palindrome[i].ToCharArray();
                for (int j = reverse.Length - 1; j >= 0; j--)
                {
                    reversed += reverse[j];                  
                    if (palindrome[i] == reversed)
                    {
                        Console.WriteLine(reversed + " ");
                    }
                }
                reversed = "";
            }

        }
    }
}
