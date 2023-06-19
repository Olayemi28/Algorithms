using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are given 5 integer numbers. Write a program that finds those 
            // subsets whose sum is 0. Examples:
            // - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
            // is 0.
            // - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
            // with sum 0

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
            Console.Write("Enter fourth number:");
            int num4;
            while (!(int.TryParse(Console.ReadLine(), out num4)))
            {
                Console.Write("Kindly enter a number:");
            }
            Console.Write("Enter fifth number:");
            int num5;
            while (!(int.TryParse(Console.ReadLine(), out num5)))
            {
                Console.Write("Kindly enter a number:");
            }
            if (num1 + num2 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num1, num2);
            }
            if (num1 + num3 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num1, num3);
            }
            if (num1 + num4 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num1, num4);
            }
            if (num1 + num5 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num1, num5);
            }
            if (num2 + num3 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num2, num3);
            }
            if (num2 + num4 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num2, num4);
            }
            if (num2 + num5 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num2, num5);
            }
            if (num3 + num4 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num3, num4);
            }
            if (num3 + num5 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num3, num5);
            }
            if (num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} = 0", num4, num5);
            }
            if (num1 + num2 + num3 == 0)
            {
                Console.WriteLine("{0} {1} {2}= 0", num1, num2, num3);
            }
            if (num1 + num2 + num4 == 0)
            {
                Console.WriteLine("{0} {1} {2}= 0", num1, num2, num4);
            }
            if (num1 + num2 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2}= 0", num1, num2, num5);
            }
            if (num1 + num3 + num4 == 0)
            {
                Console.WriteLine("{0} {1} {2}= 0", num1, num3, num4);
            }
            if (num1 + num3 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2}= 0", num1, num3, num5);
            }
            if (num1 + num4 + num5 == 0)
            {
                Console.WriteLine("{} {} {2}= 0", num1, num4, num5);
            }
            if (num2 + num3 + num4 == 0)
            {
                Console.WriteLine("{0} {1} {2}= 0", num2, num3, num4);
            }
            if (num2 + num3 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", num2, num3, num5);
            }
            if (num2 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", num2, num4, num5);
            }
            if (num3 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", num3, num4, num5);
            }
            if (num1 + num2 + num3 + num4 == 0)
            {
                Console.WriteLine("{0} {1} {2} {3} = 0", num1, num2, num3, num4);
            }
            if (num1 + num2 + num3 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} {3} = 0", num1, num2, num3, num5);
            }
            if (num1 + num2 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} {3} = 0", num1, num2, num4, num5);
            }
            if (num1 + num3 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} {3} = 0", num1, num3, num4, num5);
            }
            if (num2 + num3 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} {3} = 0", num2, num3, num4, num5);
            }
             if (num1 + num2 + num3 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} {1} {2} {3} = 0", num1, num2, num3, num4, num5);
            }
            else
            {
                Console.WriteLine("It has no subset");
            }


        }
    }
}
