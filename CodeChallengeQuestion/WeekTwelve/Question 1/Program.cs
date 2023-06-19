using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int unitOfWater = 0, sumTotal = 0, breakIndex = 0, maxElement = 0, startPoint = 0;
            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in array)
            {
                if (item > maxElement)
                {
                    maxElement = item;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
               
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] <= array[j])
                    {
                        break;
                    }
                    else
                    {
                        breakIndex = j;
                        if (array[i] > array[j])
                        {
                            unitOfWater = array[i] - array[j];
                            sumTotal += unitOfWater;
                        }
                        if (array[i] == maxElement && maxElement != array[array.Length - 1])
                        {
                            break;
                        }
                        if (array[array.Length - 2] >= array[array.Length - 1])
                        {
                            break;
                        }
                    }
                }
                i = breakIndex;
                startPoint = i;
                if (i != startPoint)
                {
                    continue;
                }
            }
        }
    }
}
