// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Contacts
{
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Demo");
            int[] intArray = { 1, 2, 3, 4 };
            char[] charArray = { 'a', 'b', 'c', 'd', };
            Program.PrintArray<int>(intArray);
            Program.PrintArray<char>(charArray);
        }
        public static void PrintArray<var>(var[] intArray)
        {
            foreach (var element in intArray)
            {
                Console.WriteLine("Printing Array " + element);
            }
        }
        public static void PrintArray(double[] doubleArray)
        {
            foreach (int element in doubleArray)
            {
                Console.WriteLine("Printing double Array");
            }
        }
        public static void PrintArray(char[] charArray)
        {
            foreach (int element in charArray)
            {
                Console.WriteLine("Printing char Array");
            }
        }*/

    class Person
    {
        public long phoneNum;
        public string firstName;
        public string lastName;
        public string email;
        public string city;
        public string state;
        public string addr;

        /*public Person(long pNo, string fname, string lname, string email, string city, string state, string addr)
        {
            this.phoneNum = pNo;
            this.firstName = fname;
            this.lastName = lname;
            this.email = email;
            this.city = city;
            this.state = state;
            this.addr = addr;
        }*/
    }
    class Contact
    {
        public static void AddPerson(List<Person> People)
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phoneNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address: ");
            person.addr = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.email = Console.ReadLine();

            Console.Write("Enter City: ");
            person.city = Console.ReadLine();

            Console.Write("Enter State: ");
            person.state = Console.ReadLine();

            People.Add(person);
        }

        public static void EditPerson(string name, List<Person> People)
        {
            foreach(var person in People)
            {
                if(person.firstName== name)
                {
                    Console.Write("Enter Last Name: ");
                    person.lastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    person.phoneNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Address: ");
                    person.addr = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    person.email = Console.ReadLine();

                    Console.Write("Enter City: ");
                    person.city = Console.ReadLine();

                    Console.Write("Enter State: ");
                    person.state = Console.ReadLine();
                }
            }
        }

        public static void DeletePerson(string name, List<Person> People)
        {
            var item = People.Single(x => x.firstName == name);
            if(item == null)
            {
                Console.WriteLine("No person found !");
                return;
            }
            People.Remove(item);
        }

        public static void Display(List<Person> People)
        {
            foreach(var person in People)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
        }
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();
            bool flag = true;
            while(flag == true)
            {
                AddPerson(People);
                Console.WriteLine("Do you want to add another person ? y/n");
                string temp = Console.ReadLine();
                if(temp != "y" && temp != "Y")
                {
                    flag = false;
                }
            }
            Console.WriteLine("*******************************************************");
            Display(People);

            Console.WriteLine("Enter First Name to edit details : ");
            string name = Console.ReadLine();

            EditPerson(name, People);

            Console.WriteLine("*******************************************************");
            Display(People);

            Console.WriteLine("Enter First Name to delete details : ");
            name = Console.ReadLine();

            DeletePerson(name, People);

            Console.WriteLine("*******************************************************");
            Display(People);
        }

    }
}