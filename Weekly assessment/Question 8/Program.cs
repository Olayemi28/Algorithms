using System;

namespace Question_8
{
    class Program
    { 
        static void Main(string[] args)
        {
            string n = string.Empty;
            int[] array = new int[10];
            int count = 0;
            bool unique = true;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                foreach(var item in array)
                {
                    if (item == number)
                    {
                        unique = false;
                        break;
                    }
                }

                if( unique )
                {
                    array[count] = number;
                    count++;
                }
            }
            for (int j = 0; j < count; j++)
            {
                n = ($"{array[j]}");
                Console.Write(n);
            }

        }
    }
}
