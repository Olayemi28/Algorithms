using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints on the console the perimeter and the area 
            // of a rectangle by given side and height entered by the user.

                    //Way 1
            // Console.Write("Enter a number:");
            // double length = double.Parse(Console.ReadLine());
            // Console.Write("Enter another number:");
            // double breath = double.Parse(Console.ReadLine());
            // double perimeter = 2 * (length + breath);
            // double area = length * breath;
            // Console.WriteLine($"The perimeter of a rectangle is {perimeter} and the area is {area}");

                         //Way 2
            Console.WriteLine("========== Calculate the perimeter and the area of a rectangle ==========");
            Console.Write("Enter a num:");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.Write("Enter a length:");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Enter a breath:");
                int breath = int.Parse(Console.ReadLine());
                double area = choice * length * breath;
                Console.WriteLine($"The area of a given rectangle is {area}"); 
            }
            else if(choice == 2)
            {
                Console.Write("Enter a length:");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Enter a breath:");
                int breath = int.Parse(Console.ReadLine());
                double perimeter = choice * (length + breath);
                Console.WriteLine($"The perimeter of a given rectangle is {perimeter}"); 
            }
            else
            {
                Console.WriteLine("Enter a valid number between 1 and 2");
            }
        }
    }
}
