using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are given a sequence of positive integer numbers given as string 
            // of numbers separated by a space. Write a program, which calculates 
            // their sum. Example: "43 68 9 23 318"  461.
            string input = "43 68 9 23 318";
            Console.WriteLine(Sum(input));
        }
        static int Sum(string value)
        {
            int sum = 0;
            string[] splitedValues = value.Split(' ');
            foreach (var item in splitedValues)
            {
                sum += int.Parse(item);
            }
            return sum;
        }
    }
}
