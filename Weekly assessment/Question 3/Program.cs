using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random randoms = new Random();
            int letters = randoms.Next(0, 26);
            Console.WriteLine(letters);
            for (int i = 0; i <= 26; i++)
            {
                if (letters == i)
                {
                    Console.WriteLine($"{alphabet[i]}");
                }
            }

        }
    }
}
