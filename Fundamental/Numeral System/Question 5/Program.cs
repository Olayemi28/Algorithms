using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts a binary number to decimal one.
            /* var watch = new System.Diagnostics.Stopwatch();

             long reminder = 0;
             long placeValue = 1;
             long save = 0;
             long decimalValue = 0;
             Console.Write("Enter a binary number:");
             long binary = long.Parse(Console.ReadLine());
             while (binary > 0)
             {
                 watch.Start();
                 reminder = binary % 10;
                 decimalValue = reminder * placeValue;
                 save += decimalValue;
                 placeValue *= 2;
                 binary /= 10;
             }
            Console.WriteLine(save);
            watch.Stop();
            Console.Write($"Execution time:{watch.ElapsedMilliseconds}ms");*/

            string saveReversedNumber = "";
            int result = 0, placeValue = 1, decimalNumber = 0;
            Console.Write("Enter any binary number:");
            string binaryNumber = Console.ReadLine();
            char[] splitBinaryNumber = binaryNumber.ToCharArray();
            for (int i = splitBinaryNumber.Length - 1; i >= 0; i--)
            {
                saveReversedNumber += splitBinaryNumber[i];
            }
            char[] reversedNumber = saveReversedNumber.ToCharArray();
            foreach (var item in reversedNumber)
            {
                if(item == '0')
                {
                    result = 0;
                }
                if(item == '1')
                {
                    result = 1;
                }
                decimalNumber += result * placeValue;
                placeValue *= 2;
            }
            Console.Write($"{binaryNumber} = {decimalNumber}");
        }
    }
}
