using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid id = Guid.NewGuid();
            Console.Write(id);
            int[] array = new int[20];
            int save = 0;
            for(int a = 1; a <= array.Length; a++)
            {
                save = a * 5;
                Console.Write($"{save}, ");
            }
        }
    }
}
