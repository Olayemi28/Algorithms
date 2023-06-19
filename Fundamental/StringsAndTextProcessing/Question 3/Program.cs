using System;

namespace Question_3
{
    class Program
    {
        static int count;
        static void Main(string[] args)
        {
            // Write a program that checks whether the parentheses are placed 
            // correctly in an arithmetic expression. Example of expression with 
            // correctly placed brackets: ((a+b)/5-d). Example of an incorrect 
            // expression: )(a+b)).

        }
        static void CheckParentheses(string expression)
        {
            char[] split = expression.ToCharArray();
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] == '(')
                {
                    count++;
                }
                if (split[0] == ')')
                {
                    Console.WriteLine("Incorrect expression.");
                }
            }
        }
    }
}
