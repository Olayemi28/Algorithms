using System;

namespace Question_15
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

                NextQuestion();
                ResponseToCorrectAnswers();
                while ()
                {

                }
               
            }
            if (product != answer)
            {
                ResponseToIncorrectAnswers();
                bool repeatQuestion = true;
                while (repeatQuestion)
                {
                    Console.WriteLine("Press the C button to continue");
                    string cont = Console.ReadLine();
                    if (cont == "C" || cont == "c")
                    {
                        continue;
                    }
                    else
                    {
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

        }
        public static void ResponseToCorrectAnswers()
        {
            Random random = new Random();
            int numbre = random.Next(1, 4);
            switch (numbre)
            {
                case 1:
                    Console.WriteLine("Very Good!");
                    break;
                        case 2:
                    Console.WriteLine("Excellent!");
                    break;
                case 3:
                    Console.WriteLine("Nice Work!");
                    break;
                case 4:
                    Console.WriteLine("Keep up the good work!");
                    break;
            }
       
        }
        public static void ResponseToIncorrectAnswers()
        {
            Random random = new Random();
            int num = random.Next(1, 4);
            switch (num)
            {
                case 1:
                    Console.WriteLine("No.Please try again!");
                    break;
                case 2:
                    Console.WriteLine("Wrong.Try once more.");
                    break;
                case 3:
                    Console.WriteLine("Dont give up!");
                    break;
                case 4:
                    Console.WriteLine("No.Keep trying!");
                    break;
            }
        }
    }

}
    

