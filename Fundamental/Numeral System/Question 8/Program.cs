using System;
using System.Collections.Generic;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter = 0;
            int placeValue = 1;
            int decimalValue = 0;
            Console.Write("Enter a hexadecimal value:");
            string input = Console.ReadLine();
            int reminder = 0;
            List<int> save = new List<int>();
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
            while(decimalValue > 0)
            {
                reminder = decimalValue % 2;
                save.Add(reminder);
                decimalValue = decimalValue / 2;
            } 
            Console.Write("BinaryValue = ");
           for (int i = save.Count - 1; i >= 0; i--)
           {
             Console.Write(save[i]);
           }
        
        }
    }
}
