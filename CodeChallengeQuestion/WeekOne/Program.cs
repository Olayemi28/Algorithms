using System;

namespace CodeChallengeQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for(int a = 0; a < 5; a++)
            {
                Console.WriteLine("Enter a number");
                number[a] = int.Parse(Console.ReadLine());
            }

            MiniMaxSum(number);
        }
       public static void MiniMaxSum(int[] array)
       {
            Array.Sort(array);
            int minSum = 0;
            int maxSum = 0;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                
                minSum += array[i];
            }
            for (int j = 1; j <= array.Length - 1; j++)
            {
                maxSum += array[j];
            }
            Console.WriteLine($"{minSum}           {maxSum}");

        }

    }
}
