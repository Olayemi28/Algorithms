using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // A given company has name, address, phone number, fax number, web 
            // site and manager. The manager has name, surname and phone number.
            // Write a program that reads information about the company and its 
            // manager and then prints it on the console.

            Console.Write("Enter your company name:");
            string companyName = Console.ReadLine();
            Console.Write("Enter your company address:");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter your company phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter your company fax number:");
            string companyFaxNumber = Console.ReadLine();
            Console.Write("Enter your company website:");
            string companyWebsite = Console.ReadLine();
            Console.Write("Enter your company manager name:");
            string managerName = Console.ReadLine();
            Console.Write("Enter your company manager surname:");
            string surname = Console.ReadLine();
            Console.Write("Enter your company manager phone number:");
            string managerPhoneNumber =Console.ReadLine();

            Console.Write($"The name of our company is {companyName},It is located at {companyAddress}.\nYou can reach us through our Phone Number {phoneNumber},");
            Console.WriteLine($"Our Comapny Fax Number {companyFaxNumber} and also through our website {companyWebsite}");
            Console.WriteLine($"You can also reach us through our manager {surname}{managerName} Number {managerPhoneNumber}.\nThanks for reaching our comapany {companyName}");
        }
    }
}
