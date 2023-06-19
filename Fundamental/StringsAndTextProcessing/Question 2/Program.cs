using System;
using System.Text;
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a string, reverse it and prints it to the 
            // console. For example: "introduction"  "noitcudortni".
            Reverse("introduction");
        }
        static void Reverse(string word)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(word[i]);
            }
            Console.Write(stringBuilder.ToString());
        }
    }
}
