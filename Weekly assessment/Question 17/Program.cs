using System;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestIndex = 0;
            int secondHighestIndex = 0;
            Console.Write("Enter students number:");
            int studentNum = int.Parse(Console.ReadLine());

            int[] score = new int[studentNum];
            string[] name = new string[studentNum];
            for(int i = 0; i < studentNum; i++)
            {
                Console.WriteLine("Enter student name:");
                name[i] = Console.ReadLine();

                Console.WriteLine($"Enter {name[i]} score");
                score[i] = int.Parse(Console.ReadLine());

                if(score[i] == score[highestIndex])
                {
                    secondHighestIndex = highestIndex;
                    highestIndex = i;
                }
                else if (score[i] > secondHighestIndex && score[i] < highestIndex)
                {
                    secondHighestIndex = i;
                }
            }
        }
    }
}
