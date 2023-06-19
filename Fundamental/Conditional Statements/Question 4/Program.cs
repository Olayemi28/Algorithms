using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Sort 3 real numbers in descending order. Use nested if statements.

            Console.Write("Enter first number:");
            int num1;
            while (!(int.TryParse(Console.ReadLine(), out num1)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter second number:");
            int num2;
            while (!(int.TryParse(Console.ReadLine(), out num2)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter third number:");
            int num3;
            while (!(int.TryParse(Console.ReadLine(), out num3)))
            {
                Console.Write("Kindly enter a number:");
            }
            int a = num1;
            int b = num2;
            int c = num3;
            int d;
            int e;
            if (num1 < num2 && num2 < num3)
            {
                d = c;
                e = a;
                a = d;
                b = b;
                c = e;
                Console.WriteLine($"The decending of the three numbers is {a},{b},{c}");
            }
            if (num2 < num1 && num1 < num3)
            {
                d = c;
                e = b;
                b = a;
                a = d;
                c = e;
                Console.WriteLine($"The decending of the three numbers is {a},{b},{c}");
            }
            if (num2 > num1 && num1 > num3)
            {
                d = b;
                e = a;
                a = d;
                b = e;
                c = c;
                Console.WriteLine($"The decending of the three numbers is {a},{b},{c}");
            }
            if (num2 > num3 && num3 > num1)
            {
                d = b;
                e = c;
                c = a;
                a = d;
                b = e;
                Console.WriteLine($"The decending of the three numbers is {a},{b},{c}");
            }
             if (num1 > num2 && num2 > num3)
            {
                d = a;
                e = b;
                a = d;
                b = e;
                c = c;
                Console.WriteLine($"The decending of the three numbers is {a},{b},{c}");
            }
        }
    }
}
