using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the smallest elements in an array");
            double[] number = { 23, 67, 89, 12, 34, 45, 41, 21 };
            double x = Min(number);
            Console.WriteLine(x);
        }
        public static double Min(double[] array)
        {
            Array.Sort(array);
            double smallest = array[0];
            return smallest;
        }
    }
}