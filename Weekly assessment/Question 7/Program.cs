using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int reversed = array.Length - 1;
            for(int a = 1; a < array.Length; a++)
            {
                Console.Write("Enter a number:");
                int element = int.Parse(Console.ReadLine());
                if(MyNewArray(array, element) == 1)
                {
                  array [reversed] = element;
                    reversed++;
                }
                Console.WriteLine($"{String.Join(',', array)}");
            }

        }
        static int MyNewArray(int[] array, int element)
        {
            int a = 0;
            foreach(var item in array)
            {
                a = 1;
            }
            return a;
        }
    }
}
