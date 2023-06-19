using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which finds the maximal sequence of consecutively
            //placed increasing integers. Example: { 3, 2, 3, 4, 2, 2, 4}  { 2, 3, 4}.

            int[] array = { 3, 2, 3, 4, 5, 2, 2, 4};
            //int[] array = { 1, 1, 2, 3, 2, 2, 2, 1 };
            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int count = 1, maxCount = 0, element = 0, smallestNumber = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        element = 
                    }
                }
            }
        }
    }
}
