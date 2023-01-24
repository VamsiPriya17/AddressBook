// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact addrBook = new Contact();
            List<Person> People = new List<Person>();
            bool flag = true;
            while(flag == true)
            {
                addrBook.AddPerson(People);
                Console.WriteLine("Do you want to add another person ? y/n");
                string temp = Console.ReadLine();
                if(temp != "y" && temp != "Y")
                {
                    flag = false;
                }
            }
            Console.WriteLine("*******************************************************");
            addrBook.Display(People);

            Console.WriteLine("Enter First Name to edit details : ");
            string name = Console.ReadLine();

            addrBook.EditPerson(name, People);

            Console.WriteLine("*******************************************************");
            addrBook.Display(People);

            Console.WriteLine("Enter First Name to delete details : ");
            name = Console.ReadLine();

            addrBook.DeletePerson(name, People);

            Console.WriteLine("*******************************************************");
            addrBook.Display(People);

            Console.WriteLine("*******************************************************");
            Console.WriteLine("Enter City/State to search for :");
            string CityOrState = Console.ReadLine();
          
            addrBook.SearchWithCityOrState(CityOrState, People);
            Console.WriteLine("*******************************************************");
            addrBook.DisplayByCityOrState(People);

            Console.WriteLine("*******************************************************");
            addrBook.CountByCity(People);
        }

    }
}