using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 2, 3, 4, 2, 2, 4 };
            int increase = 0;
            int increaseCount = 0;
            int max = 0;s
            int maxCount = 0;
            foreach (var num in numbers)
            {
                if (num != increase)
                {
                    if (maxCount < increaseCount)
                    {
                        max = increase;
                        maxCount = increaseCount;
                    }
                    increase = num;
                    increaseCount = 1;
                }
                else
                {
                   increaseCount++;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(increase + " ,");
            }

        }
    }
}
