using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void RemoveIllegalCars(string binary)
        {
            char illegal = '1';
            int counter = 0;
            char[] illegalCars = binary.ToCharArray(); 
            for (int i = 0; i < illegalCars.Length; i++)
            {
                if (illegal == illegalCars[i])
                {
                    counter++;
                }
                
                if (illegal == illegalCars[illegalCars.Length - 1])
                {
                    counter++;
                }
            }
        }
    }
}
