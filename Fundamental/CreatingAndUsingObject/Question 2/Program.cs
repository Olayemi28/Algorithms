using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the class Random. You may generate random numbers in the range
            // [100, 200] by calling Random.Next(100, 201).
            Console.Write("Enter the length of the random numbers you want: ");
            int length = int.Parse(Console.ReadLine());
            GenerateRandomNumbers(length);
        }
        static void GenerateRandomNumbers()
        {
            Random random = new Random();
            int rnd = random.Next(100, 201);
            Console.WriteLine(rnd);
        }
        static void GenerateRandomNumbers(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Random random = new Random();
                int rnd = random.Next(100, 201);
                Console.WriteLine(rnd  + " ");
            }
        }
    }
}
