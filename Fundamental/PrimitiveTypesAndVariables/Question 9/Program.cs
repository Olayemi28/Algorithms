using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two variables of type string and assign them a value “The 
            // "use" of quotations causes difficulties.” (without the outer quotes). 
            // In one of the variables use quoted string and in the other do not use it.

            string word1 = "Hello";
            string word2 = "\"World\"";
            Console.WriteLine(word1 + " " + word2);
        }
    }
}
