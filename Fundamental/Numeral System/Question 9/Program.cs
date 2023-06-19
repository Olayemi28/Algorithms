using System;
using System.Collections.Generic;
namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            long reminder = 0;
            long placeValue = 1;
            long number = 0;
            long decimalValue = 0;
            string hexaValue = " ";
            List<string> save = new List<string>();
            Console.Write("Enter a binary number:");
            long binary;
            while (!(long.TryParse(Console.ReadLine(), out binary)))
            {
                Console.Write("Kindly enter a number:");
            }
            while(binary > 0)
            {
                reminder = binary % 10;
                decimalValue = reminder * placeValue;
                number += decimalValue;
                placeValue *= 2;
                binary /= 10;
            }
            while (number > 0)
            {
                reminder = number % 16;
                number /= 16;
                if(reminder == 0)
                {
                    hexaValue = "0";
                }
                if(reminder == 1)
                {
                    hexaValue = "1";
                }
                if(reminder == 2)
                {
                    hexaValue = "2";
                }
                if(reminder == 3)
                {
                    hexaValue = "3";
                }
                if(reminder == 4)
                {
                    hexaValue = "4";
                }
                if(reminder == 5)
                {
                    hexaValue = "5";
                }
                if(reminder == 6)
                {
                    hexaValue = "6";
                }
                if(reminder == 7)
                {
                    hexaValue = "7";
                }
                if(reminder == 8)
                {
                    hexaValue = "8";
                }
                if(reminder == 9)
                {
                    hexaValue = "9";
                }
                if(reminder == 10)
                {
                    hexaValue = "A";
                }
                if(reminder == 11)
                {
                    hexaValue = "B";
                }
                if(reminder == 12)
                {
                    hexaValue = "C";
                }
                if(reminder == 13)
                {
                    hexaValue = "D";
                }
                if(reminder == 14)
                {
                    hexaValue = "E";
                }
                if(reminder == 15)
                {
                    hexaValue = "F";
                }
                save.Add(hexaValue);
            }
            for (int i = save.Count - 1; i >= 0; i--)
            {
                Console.Write(save[i]);
            }
        }
    }
}
