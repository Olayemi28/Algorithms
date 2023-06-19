using System;
using System.Collections.Generic;

namespace GameOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);
            Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("========================== Welcome to Wasir Online Game =========================");
            Console.WriteLine("To choose a category:" +
                "\nPress 0 for Names" +
                "\nPress 1 for Animals" +
                "\nPress 2 for Countries" +
                "\nPress 3 for Fruits" +
                "\nPress 4 for Things" +
                "\nPress 5 for Professions");
            int input;
            while (!(int.TryParse(Console.ReadLine(), out input) && input >= 0 && input <= 5))
            {
                Console.Write("Kindly enter a number between 0 to 5");
            }
            if(input == 0) 
            {
                PlayNameCategory();
            }
            else if(input == 1)
            {
                PlayAnimalCategory();
            }
            else if(input == 2)
            {
                PlayCountryCategory();
            }
            else if (input == 3)
            {
                PlayFruitCategory();
            }
            else if (input == 4)
            {
                PlayThingCategory();
            }
            else if (input == 5)
            {
                PlayProfessionCategory();
            }
            Console.Write("Do you like to play another game?");
        }

        static void PlayNameCategory()
        {
            string[] names = { "Faith", "Marvellous", "Grace", "Christy", "Precious", "Miracle", "Mercy", "Janet", "Happiness", "Joy" };
            var rand = 0;
            for (int i = 0; i < names.Length; i++)
            {
                Random random = new Random();
                rand = random.Next(i, names.Length - 1);
                Console.WriteLine(names[rand]);
                break;
            }
            char[] letters = names[rand].ToLower().ToCharArray();
            char underscore = '_';
            List<char> dash = new List<char>();
            for (int i = 0; i < letters.Length; i++)
            {
                dash.Add(underscore);
                Console.Write(underscore);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            bool playOn = true;
            int count = 0;
            while (playOn)
            {
                Console.Write("Guess a letter:");
                char aLetter = char.Parse(Console.ReadLine());
                for (int i = 0; i < letters.Length; i++)
                {
                    if (aLetter == letters[i])
                    {
                        count++;
                        int aLetterIndex = i;
                        char temp = '\u0000';
                        temp = dash[i];
                        dash[i] = aLetter;
                        aLetter = temp;
                        Console.Write(string.Join(" ", dash));
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                if (count == letters.Length)
                {
                    Console.WriteLine("You have succesfully guessed the word right.");
                    playOn = false;
                    break;
                }
            }
            if (playOn == false)
            {
                Menu();
            }
        }

        static void PlayAnimalCategory()
        {
            string[] animals = { "Crocodile", "Girraffe", "Cheetah", "Tortoise", "Anaconda", "Gorilla", "Jaguar", "Camel", "Chameleon", "Hippotamus" };
            for (int i = 0; i < animals.Length; i++)
            {
                Random random = new Random();
                var rand = random.Next(i, animals.Length - 1);
                Console.WriteLine(animals[rand]);
                break;
            }
        }

        static void PlayCountryCategory()
        {
            string[] countries = { "Algeria", "Guinea", "Burkinafaso", "Burundi", "Cambodia", "Ecuador", "Cuba", "Madagascar", "Mozambique", "Nicaragua" };
            for (int i = 0; i < countries.Length; i++)
            {
                Random random = new Random();
                var rand = random.Next(i, countries.Length - 1);
                Console.WriteLine(countries[rand]);
                break;
            }
        }

        static void PlayFruitCategory()
        {
            string[] fruits = { "Plum", "Blueberry", "Avocado", "Cherimoya", "Guava", "Clementhie", "Duriam", "Figs", "Jackfruit", "Loquat" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Random random = new Random();
                var rand = random.Next(i, fruits.Length - 1);
                Console.WriteLine(fruits[rand]);
                break;
            }
        }
       
        static void PlayThingCategory()
        {
            string[] things = { "Gate", "Laptop", "Book", "Torch", "Chairs", "Phone", "Guitar", "Charger", "Plate", "mouse" };
            for (int i = 0; i < things.Length; i++)
            {
                Random random = new Random();
                var rand = random.Next(i, things.Length - 1);
                Console.WriteLine(things[rand]);
                break;
            }
        }

        static void PlayProfessionCategory()
        {
            string[] professions = { "Physiologist", "Dentist", "Programmer", "Scientist", "Hawker", "Cobller", "Butcher", "Banker", "Plumber", "Engineer" };
            for (int i = 0; i < professions.Length; i++)
            {
                Random random = new Random();
                var rand = random.Next(i, professions.Length - 1);
                Console.WriteLine(professions[rand]);
                break;
            }
        }
    }
}
