// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Linq;

namespace Contacts
{
    class Person
    {
        public long phoneNum;
        public string firstName;
        public string lastName;
        public string email;
        public string city;
        public string state;
        public string addr;

    }
    class Contact : Person
    {
        public void AddPerson(List<Person> People)
        {
            Console.Write("Enter First Name: ");
            string name = Console.ReadLine();
            var candidate = People.FirstOrDefault(d => name == d.firstName);

            if (candidate != null)
            {
                EditPerson(name, People);
            }
            else
            {
                Person person = new Person();

                person.firstName = name;

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
        }

        public void EditPerson(string name, List<Person> People)
        {
            foreach(var person in People)
            {
                if(person.firstName== name)
                {
                    Console.WriteLine("Edit details :");
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

        public void DeletePerson(string name, List<Person> People)
        {
            
             foreach(Person person in People)
             {
                 if(person.firstName== name)
                 {
                     People.Remove(person);
                 }
             }
        }

        public void SearchWithCityOrState(string CityOrState, List<Person> People)
        {
            foreach(var person in People)
            {
                if(person.city == CityOrState || person.state == CityOrState)
                {
                    Console.WriteLine(person.firstName + " " + person.lastName);
                }
            }
        }

        public void Display(List<Person> People)
        {
            foreach(var person in People)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
        }

        public void DisplayByCityOrState(List<Person> people)
        {
            IDictionary<string, List<string>> cities = new Dictionary<string, List<string>>();
            IDictionary<string, List<string>> states = new Dictionary<string, List<string>>();
            foreach (Person person in people)
            {
                if (!cities.ContainsKey(person.city))
                {
                    cities[person.city] = new List<string>();
                }
                if (!states.ContainsKey(person.state))
                {
                    states[person.state] = new List<string>();
                }
                cities[person.city].Add(person.firstName + " " + person.lastName);
                states[person.state].Add(person.firstName + " " + person.lastName);
            }
            foreach (KeyValuePair<string, List<string>> city in cities)
            {
                Console.Write("Key: " + city.Key);
                foreach(string person in city.Value)
                {
                    Console.Write(" " + person);
                }
                Console.WriteLine();
            }
            foreach (KeyValuePair<string, List<string>> state in states)
            {
                Console.WriteLine("Key: " + state.Key);
                foreach (string person in state.Value)
                {
                    Console.Write(" " + person);
                }
                Console.WriteLine();
            }
        }
        public void CountByCity(List<Person> People)
        {
            IDictionary<string, int> cities = new Dictionary<string, int>();
            foreach(var person in People)
            {
                if(cities.ContainsKey(person.city))
                {
                    cities[person.city]++;
                }
                else
                {
                    cities.Add(person.city, 1);
                }
            }

            for(int i = 0; i < cities.Count; i++)
{
                Console.WriteLine("Key: " + cities.ElementAt(i).Key + " Value: " + cities.ElementAt(i).Value);
            }
        }
    }
}