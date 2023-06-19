using System;
using System.Collections.Generic;

namespace SeventhCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.Write("enter a num:");
            int n = int.Parse(Console.ReadLine());
            List<int> C = new List<int>();
            for (int i = 1, j = 1; j <= n; i++, j += i)
            {
               C.Add(j);

            }
            Console.WriteLine(C.Count);


            //OR Question 1
            Console.Write("enter a num:");
            int num = int.Parse(Console.ReadLine());
            int staircase = 0;
            int count = 0;
            for(int i = 1; i < num; i++)
            {
               staircase += i;
               if(staircase <= num)
               {
                   count++;
               }
               if(staircase > num)
               {
                   break;
               }
            }
            Console.WriteLine(count);

            //Question 2
            //int count = 0;
            //int max = 0;
            //int[] num = { 1, 1, 1, 1};
            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = 0; j < num.Length; j++)
            //    {
            //        if (num[i] - num[j] == 1 || num[i] == num[j])
            //        {
            //            count++;
            //        }
            //        if (count > max)
            //        {
            //            max = count;
            //        }
            //    }
            //    count = 0;
            //}
            //if (max == num.Length)
            //{
            //    Console.WriteLine(0);
            //}
            //else
            //{
            //    Console.WriteLine(max);
            //}


            //OR Question 2
            //     int count = 0;
            //     int max = 0;
            //     int m = 0;
            //     int[] array = { 1, 1, 1, 1};
            //     for(int i = 0; i < array.Length; i++)
            //     {
            //         for(int j = 0; j < array.Length; j++)
            //         {
            //             if(array[i] - array[j] == 1)
            //             {
            //                 m = 1;
            //                 count++;
            //             }
            //             if(array[i] == array[j])
            //             {
            //                 count++;
            //             }
            //             if(count > max)
            //             {
            //                 max = count;
            //             }
            //         }
            //         count = 0;
            //     }
            //     if (max == array.Length || m == 0)
            //     {
            //         Console.WriteLine(0);
            //     }
            //     else
            //     {
            //         Console.WriteLine(max);
            //     }
        }
    }
}
