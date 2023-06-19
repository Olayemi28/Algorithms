using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 3, 4};
            int[] array2 = { 3, 4, 3 };
            Console.WriteLine(GasStations(array1, array2));
        }
        static int GasStations(int[] gas, int[] cost)
        {
            int emptyTank = 0, startingPoint = 0, gasInTheTank = 0;
            //bool journeyContinue = true;

            for (int i = 0; i < gas.Length - 1; i++)
            {
                if (gas[i] == gas.Length - 1)
                {
                    startingPoint = gas[i] - cost[0];
                }
                for (int j = i; j < cost.Length; j++)
                {
                    if (gas[i] - cost[j] > 0)
                    {
                        startingPoint = i;
                        int anotherVar = gas[startingPoint];
                        anotherVar = emptyTank + gas[i];
                        gasInTheTank = anotherVar - cost[j] + gas[i + 1];
                        if (gasInTheTank < 0)
                        {
                            return -1;
                        }
                        if (gas[i] == gas.Length - 1)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                gasInTheTank = gasInTheTank - cost[j + 1] + gas[k];
                                if (gasInTheTank < 0)
                                {
                                    return -1;
                                }
                                for (int l = k; l < cost.Length - 2; l++)
                                {
                                    gasInTheTank = gasInTheTank - cost[l] + gas[k + 1];
                                    if (gasInTheTank < 0)
                                    {
                                        return -1;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }
            }
            return startingPoint;
        }
    }
}
