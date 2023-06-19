using System;
using System.Collections.Generic;
namespace Question_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that for a given number n, outputs a matrix in the 
            // form of a spiral:
            // Example for n=4:

            // 1 2 3 4
            // 12 13 14 5
            // 11 16 15 6
            // 10 9 8 7

            // Console.Write("N = ");
            // int n = int.Parse(Console.ReadLine());
            // int[,] matrix = new int[n, n];
            // FillMatrix(matrix, n);
            // PrintMatrix(matrix, n);
            var vals = new List<int> {1,4,9,16,25};
            Converter<int, double> converter = squareRoot;
            List<double> vals2 = vals.ConvertAll<double>(converter);
            System.Console.WriteLine(string.Join(",", vals2));
        }

        static double squareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        private static void FillMatrix(int[,] matrix, int n)
        {
            int positionX = n / 2; // The middle of the matrix
            int positionY = n % 2 == 0 ? (n / 2) - 1 : (n / 2);
            int direction = 0; // The initial direction is "down"
            int stepsCount = 1; // Perform 1 step in current direction
            int stepPosition = 0; // 0 steps already performed
            int stepChange = 0; // Steps count changes after 2 steps
            for (int i = 0; i < n * n; i++)
            {
                // Fill the current cell with the current value
                matrix[positionY, positionX] = i;
                // Check for direction / step changes
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepsCount++;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }
                // Move to the next cell in the current direction
                switch (direction)
                {
                    case 0:
                        positionY++;
                        break;
                    case 1:
                        positionX--;
                        break;
                    case 2:
                        positionY--;
                        break;
                    case 3:
                        positionX++;
                        break;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    } 
}

    

