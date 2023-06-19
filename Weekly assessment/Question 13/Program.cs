using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            string reserved = num.ToString();
            for (int i = reserved.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{reserved[i]}");
            }




        }
    }
}
