using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two variables of type string and give them values "Hello" and 
            // "World". Assign the value obtained by the concatenation of the two 
            // variables of type string (do not miss the space in the middle) to a 
            // variable of type object. Declare a third variable of type string and 
            // initialize it with the value of the variable of type object (you should use 
            // type casting).

            string word1 = "Hello";
            string word2 = "World";
            object  word3 = word1 + " " + word2;
            string word4 = (string)word3;
            Console.WriteLine(word4);
        }
    }
}
