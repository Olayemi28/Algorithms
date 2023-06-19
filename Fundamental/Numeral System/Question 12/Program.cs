using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts Arabic digits to Roman ones.
            Console.Write("Enter a number between 0 to 999:");
            int number = int.Parse(Console.ReadLine());
            int hundred = number / 100;
            if(number < 20)
            {
                Console.WriteLine($"{Unit(number)}");
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
                    Console.WriteLine($"{Tens(tens)}  {Unit(unit)}");
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
                    Console.WriteLine($"{Hundred(a)} and {Unit(c)}");
                }
                else if (b == 1)
                {
                    Console.WriteLine($"{Hundred(a)} and {Unit(bc)}");
                }
                else
                {
                    Console.WriteLine($"{Hundred(a)} and {Tens(b)} {Unit(c)}");
                }
            }

        }
        public static string Unit(int num) => num switch 
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            10 => "X",
            11 => "XI",
            12 => "XII",
            13 => "XIII",
            14 => "XIV",
            15 => "XV",
            16 => "XVI",
            17 => "XVII",
            18 => "XVIII",
            19 => "XIX",
            _ => null,
        };
        public static string Tens(int num) => num switch
        {
            2 => "XX",
            3 => "XXX",
            4 => "XL",
            5 => "L",
            6 => "LX",
            7 => "LXX",
            8 => "LXXX",
            9 => "XC",
            _ => null,
        };
        public static string Hundred(int num) => num switch
        {
            2 => "CXX",
            3 => "CXXX",
            4 => "XD",
            5 => "D",
            6 => "DX",
            7 => "DXX",
            8 => "DXXX",
            9 => "XM",
            _ => null,
        };
    }
}
