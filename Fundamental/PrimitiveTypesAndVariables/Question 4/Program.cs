using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a variable of type int with a value of 256 in
            // hexadecimal format (256 is 100 in a numeral system with base 16).

            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(number, 16).ToUpper();
            Console.WriteLine(hexadecimal);
            
        }
    }
}
