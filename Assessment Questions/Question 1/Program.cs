using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Science: day of the week) Zeller’s congruence is an algorithm developed by Christian Zeller to calculate the day of the week. The formula is

            // h= ( q+ 26(m+1)/10  +k+ k/4  + j/4+5j)  % 7

            // Where :
            //     h is the day of the week (0: Saturday, 1: Sunday, 2: Monday, 3: Tuesday, 4: Wednesday, 5: Thursday, 6: Friday). 
            //     q is the day of the month. 
            //     m is the month (3: March, 4: April, . . ., 12: December). January and February are counted as months 13 and 14 of the previous year. 
            //     j is the century (i.e., year/100). 
            //     k is the year of the century (i.e., year % 100).

            // Note: The division in the formula performs an integer division. Write a program that prompts the user to enter a year, month, and day of the month, and displays the name of the day of the week. Here are some sample runs: Enter year: (e.g., 2012): 
            // Enter month: 1-12
            // Enter the day of the month: 1-31: 
            // Day of the week is Sunday 25 1 2015
            // Enter year: (e.g., 2012):
            // Enter month: 1-12: 
            // Enter the day of the month: 1-31: 
            // Day of the week is Saturday 12 5 2012 (Hint: January and February are counted as 13 and 14 in the formula, so you need to convert the user input 1 to 13 and 2 to 14 for the month and change the year to the previous year.)


          
            Console.Write("Enter the day of the month:");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter any month of your choice:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a year:");
            int year = int.Parse(Console.ReadLine());
            
            int century = year / 100;
            int yearOfCentury = year % 100;   
            if(month == 1)
            {
                month = 13;
                year--;
            }   
            if(month == 2)
            {
                month = 14;
                year--;
            }

            int mon = 26 * (month + 1)/ 10;
            int yOC = yearOfCentury / 4;
            int cent = century / 4;
            int mBC = 5 * century;
            int daysOfWeek = (day + mon + yearOfCentury + yOC + cent + mBC) % 7;
            if(month == 13 || month == 14)
            {
                daysOfWeek -= 2;
            }
            switch(daysOfWeek)
            {
                case 0:
                Console.WriteLine($"Day of the week is Satuday {day} {month} {year}");
                break;
                case 1:
                Console.WriteLine($"Day of the week is Sunday {day} {month} {year}");
                break;
                case 2:
                Console.WriteLine($"Day of the week is Monday {day} {month} {year}");
                break;
                case 3:
                Console.WriteLine($"Day of the week is Tuesday {day} {month} {year}");
                break;
                case 4:
                Console.WriteLine($"Day of the week is Wednesday {day} {month} {year}");
                break;
                case 5:
                Console.WriteLine($"Day of the week is Thursday {day} {month} {year}");
                break;
                case 6:
                Console.WriteLine($"Day of the week is Friday {day} {month} {year}");
                break;
                default:
                Console.WriteLine("Invalid input");
                break;
            }
            
           
        }
    }
}
