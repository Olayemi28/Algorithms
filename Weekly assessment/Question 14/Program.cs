using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our annual quiz competition for the elementry students");
            Random random1 = new Random();
            int num1 = random1.Next(0, 9);

            Random random2 = new Random();
            int num2 = random2.Next(0, 9);

            int product = num1 * num2;
            Console.WriteLine($"What will be the answer of this two product {num1} * {num2}");
            int answer = int.Parse(Console.ReadLine());

            if (answer == product)
            {
                Console.WriteLine("Very Good!");
                bool nextQuestion = true;
                while (nextQuestion)
                {
                    NextQuestion();
                    Console.WriteLine("Press the Y button to continue");
                    string respond = Console.ReadLine();
                    if (respond == "Y" || respond == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            if (product != answer)
            {
               Console.WriteLine("No.Please try again.");
                   
                bool repeatQuestion = true;
                while (repeatQuestion)
                {
                    Console.WriteLine($"What is the result of this two product:{num1} * {num2} ");
                    int res = int.Parse(Console.ReadLine());
                    if (res==product)
                    {
                        Console.WriteLine("Correct answer");
                        break;
                    }
                   
                }

            }
            
        }

        public static void NextQuestion()
        {
            Random random1 = new Random();
            int num1 = random1.Next(0, 9);

            Random random2 = new Random();
            int num2 = random2.Next(0, 9);

            int total = num1 * num2;
            Console.WriteLine($"{num1} * {num2}");
            int result = int.Parse(Console.ReadLine());
            
            
            return;
        }
    }    
 }
