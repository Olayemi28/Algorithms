using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two variables of type string with values "Hello" and "World". 
            // Declare a variable of type object. Assign the value obtained of 
            // concatenation of the two string variables (add space if necessary) to this 
            // variable. Print the variable of type object.

            string word1 = "Hello";
            string word2 = "World";
            object word3 = word1 + " " + word2;
            Console.WriteLine(word3);
        }
    }
}
