using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and 
            // decimal numeral systems.
            int[] array = {0XFA, 0X2A3E, 0XFFFF, 0X5A0E90};
            string[] hexadecimal = {"FA", "2A3E", "FFFF", "5A0E9"};
            string binaryNumber = " ";
            string decimalNumber = " ";
            Console.WriteLine("{0, -15}  {1, -25}  {2, -30}", "Hexadecimal", "BinaryNumber", "DecimalNumber");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                int count = i;
                binaryNumber = Convert.ToString(array[i], 2);
                decimalNumber = Convert.ToString(array[i], 10);
                Console.WriteLine("{0, -15}  {1, -25}  {2, -30}",hexadecimal[count], binaryNumber, decimalNumber);
                count++;
            }
            Console.WriteLine();
        }
    }
}
