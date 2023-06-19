using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> n1 = new List<int>() { 3, 2, 1, 4 };
            //List<int> n2 = new List<int>() { 1,2,3,4 };
            //List<int> res = n1.Intersect(n2).ToList();

            //We are given the number n, the value v(v = 0 or 1) and the position p. 
            //write a sequence of operations that changes the value of n, so the bit on
            //the position p has the value of v. Example: n = 35, p = 5, v = 0->n = 3.
            //Another example: n = 35, p = 2, v = 1->n = 39.

            Console.Write("Enter a num:");
            int dec = int.Parse(Console.ReadLine());
            string bin = Convert.ToString(dec, 2);
            Console.WriteLine(bin);
            int bit3 = (dec & 6);
            bool result = bit3 != 0 ? true : false;
            Console.WriteLine(result);

            //ulong x2 = 1;
            //ulong x3 = 0;
            //Console.Write("Enter a number:");
            //int N = int.Parse(Console.ReadLine());
            //for (int a = 0; a < N; a++)
            //{
            //    x3 = x2 + x1;
            //    x1 = x2;
            //    x2 = x3;
            //    Console.WriteLine(a == 0 ? $"{a}\n{x2}\n{x3}" : $"{x3}");
            //}


            // (Game: lottery) Lottery, to generate a lottery of a three digit number. 
            // The program prompts the user to enter a three-digit number and determines whether the user wins according to the following rules:
            // 1. If the user input matches the lottery number in the exact order, the award is $10,000.
            // 2. If all the digits in the user input match all the digits in the lottery number, the award is $3,000.
            // 3. If one digit in the user input matches a digit in the lottery number, the award is $1,000.


            //Console.WriteLine("=============== Welcome to wasir game lottery ===============");
            //bool isContinue = true;
            //while(isContinue)
            //{
            //    Random random = new Random();
            //    int number = random.Next(100, 1000);
            //    Console.WriteLine(number);

            //    Console.Write("Enter a number:");
            //    int num = int.Parse(Console.ReadLine());

            //    if(number == num)
            //    {
            //        Console.WriteLine("Congratulations!!! You won $10000");
            //    }
            //    else if(number == num)
            //    {
            //        Console.WriteLine("You did great!!! You won $3000");
            //    }
            //    else if(number == num)
            //    {
            //        Console.WriteLine("Nice one! You won $1000");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number not found");
            //    }

            //    Console.WriteLine("Do you want to continue the game:Yes/No");
            //    string response = Console.ReadLine();
            //    if(response.ToUpper() == "Yes".ToUpper())
            //    {
            //        isContinue = true;
            //    }
            //    else if(response.ToUpper() == "No".ToUpper())
            //    {
            //        isContinue = false;
            //        Console.WriteLine("Thanks for playing with us.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input.Enter the correct answer");
            //    }
            //}

            // var list = new List<int>();
            // list.Add(1);
            // list.Add(2);
            // list.Add(3);
            // list.Remove(1);

            // var arrayList = new ArrayList();
            // arrayList.Add(12);
            // arrayList.Add("Inioluwa");
            // arrayList.Add('a');
            // arrayList.Remove("Inioluwa");

            // var queue = new Queue<string>();
            // queue.Enqueue("Ade");
            // queue.Enqueue("Ola");
            // queue.Enqueue("Eniola");
            // queue.Dequeue();

            // var que = new Queue();
            // que.Enqueue(123);
            // que.Enqueue('g');
            // que.Enqueue(12.34);
            // que.Dequeue();

            // var stack = new Stack<char>();
            // stack.Push('f');
            // stack.Push('k');
            // stack.Push('m');
            // stack.Pop();

            // var stac = new Stack();
            // stac.Push(659);
            // stac.Push("Ayomide");
            // stac.Push(25.09);
            // stac.Pop();

            // var dictionary = new Dictionary<string, char>();
            // dictionary.Add("Opeyemi", 'O');
            // dictionary.Add("Oyeyemi", 'O');
            // dictionary.Add("Olayemi", 'O');
            // dictionary.Remove("Oyeyemi");

            // var hashtable = new Hashtable();
            // hashtable.Add(1, "Ade");
            // hashtable.Add('A', 70);
            // hashtable.Add("Height", 64.5);
            // hashtable.Remove('A');

            // var sortedList = new SortedList<int, string>();
            // sortedList.Add(12, "Olaide");
            // sortedList.Add(19, "Abeeb");
            // sortedList.Add(17, "Abdul-Basit");
            // sortedList.Remove(12);

            // var sortList = new SortedList();
            // sortList.Add("Adebayo", "Abass");
            // sortList.Add("Olaoluwa", 'O');
            // sortList.Add("Dominion", 56.9);
            // sortList.Remove("Adebayo");

            // Palindrome("Malam");
            // NumberOfLetters("Conversion");
        }

        static bool CheckEquality(List<int> first, List<int> second)
        {
            if(first.Count != second.Count)
            {
                return false;
            }
            return first.Intersect(second).ToList().Count() == first.Count ? true : false;
        }
        static bool CheckEqualities(List<int> first, List<int> second)
        {
            if(first.Count != second.Count)
            {
                return false;
            }
            return first.Intersect(second).ToList().Count() == 1 ? true : false;
        }
        static void Palindrome(string word)
        {
            var stack = new Stack<char>();
            string w = "";
            foreach (var item in word)
            {
               stack.Push(item);
            }
            int d = stack.Count;
             
            for(int i = 0; i < d; i++)
            {
                w += stack.Pop();
            }
            if(w.ToUpper() == word.ToUpper())
            {
                Console.WriteLine($"{word} is palindromic");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrone");
            }
        }

        static void NumberOfLetters(string letter)
        {
            var dictionary = new Dictionary<char, int>();
           foreach (var item in letter)
           {
                if(dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
           }
           foreach (var items in dictionary)
            {
                Console.WriteLine($"{items.Key}  = {items.Value}");
            }
           
        }

    }
}
