using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that shows the sign (+ or -) of the product of three real 
            // numbers, without calculating it. Use a sequence of if operators.

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


           if (num1 < 0 && num2 > 0 && num3 < 0)    
           {
              Console.WriteLine("");
              Console.WriteLine($"The result is Positive (+)");
           }
           if (num1 > 0 && num2 < 0 && num3 < 0)
           {
                Console.WriteLine("");
                Console.WriteLine($"The result is Positive (+)");
           }
           if (num1 < 0 && num2 < 0 && num3 > 0)
           {
                Console.WriteLine("");
                Console.WriteLine($"The result is Positive (+)");
           }
            if (num1 < 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"The result is Negative (-)");
            }
            if (num1 < 0 && num2 > 0 && num3 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"The result is Negative (-)");
            }
            if (num1 > 0 && num2 < 0 && num3 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"The result is Negative (-)");
            }
            if (num1 > 0 && num2 > 0 && num3 < 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"The result is Negative (-)");
            }
           if (num1 > 0 && num2 > 0 && num3 > 0)
           {
              Console.WriteLine("");
              Console.WriteLine($"The result is Positive (+)");
           }
           if(num1 == 0 || num2 == 0 || num3 == 0)
           {
               Console.WriteLine("");
               Console.WriteLine($"The result is Zero");
           }
        }
    }
}
