using System;
using System.Collections.Generic;

namespace FourthCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstAndLastPosition();
        }
        public static void FirstAndLastPosition()
        { 
            
            List<int> num = new List<int>();
            int count = 0;
            int startingPoint = 0;
            int endingPoint = 0;
            Console.Write("Enter a num:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Console.Write("Enter a target:");
            int target = int.Parse(Console.ReadLine());
            for(int i = 0; i < array.Length; i++){
                Console.Write("Enter an element:");
                array[i] = int.Parse(Console.ReadLine());
              Array.Sort(array);
              if (array[i] == target)
              {
                 int a = i;
                 num.Add(a);
              }
              else{
                  count++;
              }
            if(count == array.Length){
                Console.WriteLine("[-1,-1]");
            }
            if (count == 0 || count != array.Length)
            {
                for(int b = 0; b < num.Count; b++ ){
                    if(b == 0){
                     startingPoint =  num[b];  
                    }
                    if(b > 0){
                        endingPoint = num[i];
                 
                    }
                    Console.WriteLine($"{startingPoint}{endingPoint}");
                }
            }
            
        }
        // public static void LongestPrefix(){
        //     Console.Write("Enter any palindromic words");
        //     string word = Console.ReadLine();
            
        // }
         static void TwoSum(){
            Console.Write("Enter a num:");
            int length = int.Parse(Console.ReadLine());
            int[]array = new int[length];
            Console.Write("Enter a target:");
            int target = int.Parse(Console.ReadLine());
            for(int i = 0; i < array.Length; i++){
             Console.Write("Enter an element:");
             array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The num you entered are:");
            foreach(var item in array){
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            for(int x = 0; x < array.Length; x++){
                for(int y = x + 1; y < array.Length; y++){
                    if(array[x] + array[y] == target){
                        Console.WriteLine($"{x},{y}");
                    }
                }
            }
        }
    }
}
}