using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert the number 1111010110011110(2) to hexadecimal and decimal
            // numeral systems.
            int binaryNumber = 0b_1111_0101_1001_1110;
            string decimalNumber = Convert.ToString(binaryNumber, 10);
            Console.WriteLine(decimalNumber);
            string hexadecimal = Convert.ToString(int.Parse(decimalNumber), 16).ToUpper();
            Console.WriteLine(hexadecimal);
        }
    }
}
