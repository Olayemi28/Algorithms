using System;
using System.Collections.Generic;

namespace Tenth_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question1(5,6));
        }

        public static int Question1(int chair, int numberOfCircle)
        {
           List<int> num = new List<int>();
           for(int i = 1; i <= chair; i++)
           {
               num.Add(i);
           }
           int count = num.Count;
           int drop = numberOfCircle - 1;
           for(int j = 0; j < count; j++)
           {
              if(num.Count > 1)
              {
                   if(num.Count > drop)
                    {
                        
                        num.RemoveAt(drop);
                        drop += numberOfCircle - 1;
                    }
                    else if(num.Count <= drop)
                    {
                        drop = drop % num.Count;
                        num.RemoveAt(drop);
                        drop += numberOfCircle - 1;
                    }
              }
           }
           int last = num[0];
           return last;
        }

        public static void Question2()
        {

        }

        public static void Question3()
        {

        }
    }
}
