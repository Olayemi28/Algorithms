using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            long reminder = 0;
            long placeValue = 1;
            long save = 0;
            long decimalValue = 0;
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
                save += decimalValue;
                placeValue *= 2;
                binary /= 10;
            }
           Console.WriteLine(save);
        }
    }
}
