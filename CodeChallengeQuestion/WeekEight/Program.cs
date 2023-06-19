using System;
using System.Collections.Generic;

namespace EighthCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter any word:");
            string s = Console.ReadLine();
            Console.Write("Enter another any word:");
            string p = Console.ReadLine();
            if (Question1(s, p))
            {
                Console.WriteLine( true);
            }
            else
            {
              Console.WriteLine(  false);
            }
        }
        public static bool Question1(string s1, string s2)
        {
            int p1 = s1.Length;
            int p2 = s2.Length;
            if(p1 != p2)
            {
                return true;
            }
            for(int i = 0; i <= p1; i++)
            {
                Console.Write(p1);
            }
            for (int i = 0; i <= p2; i++)
            {
          
                Console.Write(p2);
            }
            for(int j = 0; j < p1; j++)
            {
                if(s1[j] == s2[j])
                {
                    return false;
                }
            }
            return true;

        }
        public static void Question2()
        {

        }
    }
}
