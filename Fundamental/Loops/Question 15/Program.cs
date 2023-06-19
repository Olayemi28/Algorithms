using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a given number from hexadecimal to 
            // decimal notation.

            int letter = 0;
            int placeValue = 1;
            int decimalValue = 0;
            string input = "DADA";
            char[] hexa = input.ToCharArray();
            for(int item = hexa.Length-1; item >= 0; item--)
            {
                    if (hexa[item] == 'A')
                    {
                        letter = 10;
                    }
                    if (hexa[item] == 'B')
                    {
                        letter = 11;
                    }
                    if (hexa[item] == 'C')
                    {
                        letter = 12;
                    }
                    if (hexa[item] == 'D')
                    {
                        letter = 13;
                    }
                    if (hexa[item] == 'E')
                    {
                        letter = 14;
                    }
                    if (hexa[item] == 'F')
                    {
                        letter = 15;
                    }
                    if (hexa[item] == '1')
                    {
                        letter = 1;
                    }
                    if (hexa[item] == '2')
                    {
                        letter = 2;
                    }
                    if (hexa[item] == '3')
                    {
                        letter = 3;
                    }
                    if (hexa[item] == '4')
                    {
                        letter = 4;
                    }
                    if (hexa[item] == '5')
                    {
                        letter = 5;
                    }
                    if (hexa[item] == '6')
                    {
                        letter = 6;
                    }
                    if (hexa[item] == '7')
                    {
                        letter = 7;
                    }
                    if (hexa[item] == '8')
                    {
                        letter = 8;
                    }
                    if (hexa[item] == '9')
                    {
                        letter = 9;
                    }

                    decimalValue += letter * placeValue;
                    placeValue = placeValue * 16;
            }
            Console.WriteLine("Decimal Value = {0}", decimalValue);
   
        }
    }
}
