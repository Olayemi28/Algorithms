using System;

namespace FifthCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] array = new int[] { 10, 5, -3, 3, 2, 0, 11, 3, -2, 0, 1 };
            Console.Write("enter your target num:");
            int target = int.Parse(Console.ReadLine());
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

            //int[] array = new int[] { 1,1,1,2,2,3};
            //for (int a = 0; a < array.Length; a++)
            //{
            //    for(int b = 1; b < array.Length; b++)
            //    {
            //        if (array[a] == array[b])
            //        {

            //        }
            //    }
            //}
        }
    }
}
