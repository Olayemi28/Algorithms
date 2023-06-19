using System;

namespace Question_18
{
    class Programa
    {
        static void Main(string[] args)
        {
            int countHead = 0;
            int countTail = 0;
            for (int a = 0; a < 1000000; a++)
            {
                Random random = new Random();
                int number = random.Next(0, 2);

                if (number == 0)
                {

                    countHead++;
                }
               else if (number == 1)
               {
                    countTail++;
               }
            }
            Console.WriteLine($"The number of time the head display is {countHead} while the tail is {countTail}");
        }
    }
}



