using System;
using System.Collections.Generic;

namespace Question_11
{
    class Program
    {
        // static double squareRoot(int x)
        // {
        //     return Math.Sqrt(x);
        // }
        static void Main(string[] args)
        {
            // var vals = new List<int> { 1, 4, 9, 16, 25 };
            // Converter<int, double> converter = squareRoot;
            // List<double> vals2 = vals.ConvertAll<double>(converter);
            // System.Console.WriteLine(string.Join(",", vals2));
            //***************************************************************************
            // * Write a program that converts a number in the range [0…999] to 
            // words, corresponding to the English pronunciation. Examples:
            // - 0 --> "Zero"
            // - 12 --> "Twelve"
            // - 98 --> "Ninety eight"
            // - 273 --> "Two hundred seventy three"
            // - 400 --> "Four hundred"
            // - 501 --> "Five hundred and one"
            // - 711 --> "Seven hundred and eleven"

            Console.Write("Enter a number between 0 to 999:");
            int number = int.Parse(Console.ReadLine());
            //int hundred = number / 100;
            if(number < 20)
            {
                Console.WriteLine($"{Words(number)}");
            }
           else if(number >= 20 && number <= 99)
           {
                if(number % 10 == 0)
                {
                    Console.WriteLine($"{Tens(number)}");
                }
                else
                {
                    int tens = number / 10;
                    int unit = number % 10;
                    Console.WriteLine($"{Tens(tens)}  {Words(unit)}");
                }
           }
            else if (number > 99 && number <= 999)
            {
                int a = number / 100;
                int bc = number % 100;
                int b = bc / 10;
                int c = bc % 10;
                
                if(b == 0 && c == 0)
                {
                    Console.WriteLine($"{Hundred(a)} ");
                }
                else if(c == 0)
                {
                    Console.WriteLine($"{Hundred(a)} and {Tens(b)}");
                }
                else if(b == 0)
                {
                    Console.WriteLine($"{Hundred(a)} and {Words(c)}");
                }
                else if (b == 1)
                {
                    Console.WriteLine($"{Hundred(a)} and {Words(bc)}");
                }
                else
                {
                    Console.WriteLine($"{Hundred(a)} and {Tens(b)} {Words(c)}");
                }
            }
        }

        public static string Words(int num) => num switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            10 => "Ten",
            11 => "Eleven",
            12 => "Twelve",
            13 => "Thirteen",
            14 => "Fourteen",
            15 => "Fifteen",
            16 => "Sixteen",
            17 => "Seventeen",
            18 => "Eighteen",
            19 => "Nineteen",
            _ => null,
        };

        public static string Tens(int num) => num switch
        {
            2 => "Twenty",
            3 => "Thirty",
            4 => "Fourty",
            5 => "Fifty",
            6 => "Sixty",
            7 => "Seventy",
            8 => "Eighty",
            9 => "Ninety",
            _ => null,
        };
        public static string Hundred(int num) => num switch
        {
            1 => "One hundred",
            2 => "Two hundred",
            3 => "Three hundred",
            4 => "Four hundred",
            5 => "Five hundred",
            6 => "Six hundred",
            7 => "Seven hundred",
            8 => "Eight hundred",
            9 => "Nine hundred",
            _ => null,
        };

    }
}
