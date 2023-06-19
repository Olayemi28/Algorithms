using System;
using System.Collections;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a given number from decimal to 
            // hexadecimal notation.

            int reminder = 0;
            Stack stack = new Stack();
           
            string letter = " ";
            object result = " ";
            Console.Write("Enter a decimal number:");
            int num;
            while (!(int.TryParse(Console.ReadLine(), out num))) 
            {
                Console.Write("Kindly enter a number:");
            }
            while(num > 0)
            {
                reminder = num % 16;
                num /= 16;
                    if (reminder == 0)
                    {
                        letter = "0";
                    }
                    if (reminder == 1)
                    {
                        letter = "1";
                    }
                    if (reminder == 2)
                    {
                        letter = "2";
                    }
                    if (reminder == 3)
                    {
                        letter = "3";
                    }
                    if (reminder == 4)
                    {
                        letter = "4";
                    }
                    if (reminder == 5)
                    {
                        letter = "5";
                    }
                    if (reminder == 6)
                    {
                        letter = "6";
                    }
                    if (reminder == 7)
                    {
                        letter = "7";
                    }
                    if (reminder == 8)
                    {
                        letter = "8";
                    }
                    if (reminder == 9)
                    {
                        letter = "9";
                    }
                    if (reminder == 10)
                    {
                        letter = "A";
                    }
                    if (reminder == 11)
                    {
                        letter = "B";
                    }
                    if (reminder == 12)
                    {
                        letter = "C";
                    }
                    if (reminder == 13)
                    {
                        letter = "D";
                    }
                    if (reminder == 14)
                    {
                        letter = "E";
                    }  
                    if (reminder == 15)
                    {
                        letter = "F";
                    }
                stack.Push(letter);    
            }
            while(stack.Count - 1 >= 0 )
            {
                result = stack.Pop();
                Console.Write(result);
            }
            
        }
    }
}
