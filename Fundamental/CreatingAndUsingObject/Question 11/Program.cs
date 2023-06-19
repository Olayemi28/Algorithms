using System;
using System.Collections.Generic;
namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which generates a random advertising message for 
            // some product. The message has to consist of laudatory phrase, followed 
            // by a laudatory story, followed by author (first and last name) and city, 
            // which are selected from predefined lists. For example, let’s have the 
            // following lists:
            // - Laudatory phrases: {"The product is excellent.", "This is a great 
            // product.", "I use this product constantly.", "This is the best product 
            // from this category."}.
            // - Laudatory stories: {"Now I feel better.", "I managed to change.", 
            // "It made some miracle.", "I can’t believe it, but now I am feeling 
            // great.", "You should try it, too. I am very satisfied."}.
            // - First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}.
            // - Last name of the author: {"Johnson", "Peterson", "Charls"}.
            // - Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}.
            // Then the program would print randomly generated advertising message
            // like the following:
            // I use this product constantly. You should try it, too. I am 
            // very satisfied. -- Hellen Peterson, Berlin
            RandomAdvertisingMessages();
        }
        static void RandomAdvertisingMessages()
        {
            string[] laudatoryPhrases =  {"The product is excellent.", "This is a great  product.",
            "I use this product constantly.", "This is the best product " + 
            "from this category."};

            string[] laudatoryStories = {"Now I feel better.", "I managed to change.", 
            "It made some miracle.", "I can’t believe it, but now I am feeling" + 
            "great.", "You should try it, too. I am very satisfied."};

            string[] authorFirstName = {"Dayan", "Stella", "Hellen", "Kate"};

            string[] authorLastName = {"Johnson", "Peterson", "Charls"};

            string[] cities = {"London", "Paris", "Berlin", "New York", "Madrid"};

            for (int i = 0; i < 5; i++)
            {
                Random random1 = new Random();
                int rand1 = random1.Next(i, laudatoryPhrases.Length);

                Random random2 = new Random();
                int rand2 = random2.Next(i, laudatoryStories.Length);

                Random random3 = new Random();
                int rand3 = random3.Next(i, authorFirstName.Length);

                Random random4 = new Random();
                int rand4 = random4.Next(i, authorLastName.Length);

                Random random5 = new Random();
                int rand5 = random5.Next(i, cities.Length);

                Console.Write($"{laudatoryPhrases[rand1]}.{rand2}. --{rand3} {rand4}, {rand5}");
                break;
            }
            
        }
    }
}
