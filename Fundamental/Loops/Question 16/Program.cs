using System;
using System.Collections;
using System.Collections.Generic;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that by a given integer N prints the numbers from 1 to N 
            // in random order.

            Random random = new Random();
            int number, randomNumber;
            Console.Write("Enter a number:");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            List<int> save = new List<int>();
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = a;

            }
            foreach(int a in array)
            {
                randomNumber = random.Next(0, N);
                number = array[a];
                if(array[a] != randomNumber)
                {
                    array[a] = array[randomNumber];
                    array[randomNumber] = number;
                    save.Add(array[a]);
                }
                if (!save.Contains(number))
                {
                    Console.Write(array[number]);
                }
            }
            Console.WriteLine();
            
        }
    }
}
