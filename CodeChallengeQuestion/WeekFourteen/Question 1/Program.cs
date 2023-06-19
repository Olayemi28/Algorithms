using System;
using System.Collections.Generic;
using System.Collections;

namespace Question_1
{
    class Program
    {
        static List<int> save = new List<int>();
        static int saveIndex = 0;
        //static int saveResult = 0;
        static void Main(string[] args)
        {
            int[] array = { };
            Asteroids(array);
            
        }

        static void Asteroids(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                if (arr[i] > 0)
                {
                    save.Add(arr[i]);
                }
                if (arr[i] < 0)
                {
                    if (Math.Abs(arr[i]) < arr[i - 1])
                    {
                        continue;
                    }
                    if (Math.Abs(arr[i]) >= arr[i - 1])
                    {
                        save.Add(arr[i - 1]);
                        save.Remove(arr[i - 1]);
                    }
                    if (arr[i] < 0 && arr[i - 1] < 0)
                    {
                        save.Add(arr[i]);
                        save.Add(arr[i - 1]);
                    }
                }

                if (arr[i] < 0)
                {
                    saveIndex = i;
                    i = saveIndex - 1;
                    if (arr.Length <= 2)
                    {
                        break;
                    }
                }
            }
            for (int i = save.Count - 1; i >= 0 ; i--)
            {
                Console.Write($"{save[i]} ");
            }
        }
    }
}
