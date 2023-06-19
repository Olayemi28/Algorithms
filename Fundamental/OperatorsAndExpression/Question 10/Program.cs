using System;
using System.Collections.Generic;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that takes as input a four-digit number in format abcd
            // (e.g. 2011) and performs the following actions:
            // - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            // - Prints on the console the number in reversed order: dcba (in our 
            // example 1102).
            // - Puts the last digit in the first position: dabc (in our example 1201).
            // - Exchanges the second and the third digits: acbd (in our example 
            // 2101)

            // Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            // Prints on the console the number in reversed order: dcba (in our example 1102).

            Console.Write("Enter a number:"); 
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
               
            Console.WriteLine("1.Sum of digits:{0}", a + b + c  + d);
            Console.WriteLine("In reverse order:{3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("Puts the last digit in the first position:{3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("Replace third and second digit:{0}{2}{1}{3}", a, b, c, d);

           // Puts the last digit in the first position: dabc (in our example 1201).
            // Console.Write("Enter a number:");
            // int numb = int.Parse(Console.ReadLine());
            // int num = numb % 10;
            // int remain = numb / 10;
            // string last = "";
            // last += num;
            // last += remain;
            // Console.WriteLine(last);

            //Exchanges the second and the third digits: acbd (in our example 2101)
            // Console.WriteLine("Enter a number:");
            // int num = int.Parse(Console.ReadLine());
            // string s = "";
            // int n = num % 10;
            // int rem = num / 10;
            // int nu = rem % 10;
            // int remi = rem / 10;
            // int numb = remi % 10;
            // int remin = remi / 10;
            // int number = remin % 10;
            // int remind = remin / 10;
            // s += number;
            // s += nu;
            // s += numb;
            // s += n;
            // Console.Write(s);
        }
    }
}
