using System;
using System.Collections.Generic;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 1, 2, 3, 4, 5, 6, 7, 10, 9 };

            GameOfStones(array);
        }
        static void GameOfStones(int[] n)
        {
            List<string> save = new List<string>();
            bool playOn = true;
            for (int i = 0; i < n.Length; i++)
            {
                while (n[i] >= 2)
                {
                    int input = int.Parse(Console.ReadLine());
                    if (n[i] % input >= 2 || n[i] % input >= 3 || n[i] % input >= 5)
                    {
                       playOn = true;
                    }
                    else
                    {
                        playOn = false;
                    }
                        
                }
                if (playOn == true)
                {
                    save.Add("First");
                }
                else if (playOn == false)
                {
                    save.Add("Second");
                }
            }
            for(int a = 0; a < save.Count - 1; a++)
            {
                Console.WriteLine(save[a]);
            }
        }
        
    }
}
