using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // How many backslashes you must specify as an argument to the method 
            // Split(…) in order to split the text by a backslash?
            // Example: one\two\three.
            SplitText("How many backslashes");
        }
        static void SplitText(string text)
        {
            string split = text.Replace(" ", "\\");
            foreach (var item in split)
            {
                Console.Write(item);
            }
        }
    }
}
