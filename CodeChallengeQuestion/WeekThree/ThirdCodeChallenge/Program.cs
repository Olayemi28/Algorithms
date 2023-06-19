using System;

namespace ThirdCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagonalDifference();
        }
        public static void DiagonalDifference()
        {
            Console.Write("Enter a num:");
            int num = int.Parse(Console.ReadLine());
            int[,] arr = new int[num, num];
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    Console.Write($"Enter number at row {x}  column {y}: ");

                    arr[x, y] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    Console.Write(arr[x, y] + " ");

                }

                Console.WriteLine();
            }
            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;
            int absoluteDifference = 0;
            for (int i = 0; i < num; i++)
            {
                sumRightDiagonal += arr[i, num - 1 - i];
                sumLeftDiagonal += arr[i, i];
                absoluteDifference = Math.Abs(sumLeftDiagonal - sumRightDiagonal);
            }
            Console.WriteLine(absoluteDifference);

        }
    }
}

