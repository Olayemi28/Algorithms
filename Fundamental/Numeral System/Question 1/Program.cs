using System;
using System.Collections.Generic;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary 
            // numeral system.

            //....................................................................
            //Using imbuilt method......
            int[] array = {151, 35, 43, 251, 1023, 1024};
            foreach (var item in array)
            {
                string binaryNumber = Convert.ToString(item, 2);
                Console.WriteLine(binaryNumber);
            }



            //int[] num = { 151, 35, 43, 251, 1023, 1024 };
            //Numeral(num);
            //-------------------------------------------------------------------------
            //Using normal way......
            // Console.Write("{");
            // string save = " ", res = " ";
            // int reminder = 0;
            // for(int i = 0; i < num.Length; i++)
            // {
            //     save = " ";
            //     res = " ";
            //     while (num[i] > 0)
            //     {
            //         reminder = num[i] % 2;
            //         num[i] = num[i] / 2;
            //         save += reminder;
            //     }
            //     for(int a = save.Length -1; a > 0; a--)
            //     {
            //         Console.Write(save[a]);
            //     }
            //     if(i < num.Length - 1)
            //     {
            //         Console.Write(",");
            //     }
            // }
            // Console.Write("}");
        }
        //===========================================================================
        //Using method way...........
    //    static void Numeral(int[] num)
    //    {
    //         string save = " ", res = " ";
    //         int reminder = 0;
    //         for(int i = 0; i < num.Length; i++)
    //         {
    //             res = "";
    //             save = "";
    //             while (num[i] > 0)
    //             {
    //                 reminder = num[i] % 2;
    //                 save += reminder;
    //                 num[i] = num[i] / 2;
    //             }
    //             res = Reverse(save);
    //             Console.WriteLine(res);
    //         }
    //    }
    //    static string Reverse(string num)
    //    {
    //         string res = " ";
    //         for(int i = num.Length -1; i >= 0; i--)
    //         {
    //             res += num[i];
    //         }
    //         return res;
    //    }
    }
}
