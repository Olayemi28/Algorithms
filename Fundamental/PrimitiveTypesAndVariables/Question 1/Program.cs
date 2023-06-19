using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare several variables by selecting for each one of them the most
            // appropriate of the types sbyte, byte, short, ushort, int, uint, long
            // and ulong in order to assign them the following values: 52, 130; -115;
            // 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
            // 1990; 123456789123456789


            // sbyte num1 = 52;
            // byte num2 = 130;
            // sbyte num3 = -115;
            // uint num4 = 4825932;
            // sbyte num5 = 97;
            // int num6 = -10000;
            // uint num7 = 20000;
            // byte num8 = 224;
            // int num9 = 970700000;
            // byte num10 = 112;
            // sbyte num11 = -44;
            // int num12 = -1000000;
            // short num13 = 1990;
            // long num14 = 123456789123456789;

            Console.Write("Enter any thing:");
            int input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 0:
                Console.WriteLine(input++);
                break;
                case 1:
                Console.WriteLine(input + "*");
                break;
                case 2:
                Console.WriteLine(input++);
                break;
                default:
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}
