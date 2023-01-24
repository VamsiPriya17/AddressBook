using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegEx
{
    public class UserRegistration
    {
        private static bool ValidateFirstName;
        private static bool ValidatePhoneNumber;
        private static bool ValidateLastName;
        private static bool ValidateEmail;
        private static bool ValidatePassword;
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Password;

        public void TakeFirstName()
        {
            do
            {
                Console.Write("Enter First Name: ");
                this.FirstName = Console.ReadLine();
                ValidateFirstName = PatternClass.ValidateFirstName(this.FirstName);
                DisplayOutput("FirstName", ValidateFirstName);
            }while(!ValidateFirstName);
        }
        public void TakeLastName()
        {
            do
            {
                Console.Write("Enter Last Name: ");
                this.LastName = Console.ReadLine();
                ValidateLastName = PatternClass.ValidateLastName(this.LastName);
                DisplayOutput("LastName", ValidateLastName);
            } while (!ValidateLastName);
        }
        public void TakeEmail()
        {
            do
            {
                Console.Write("Enter Email: ");
                this.Email = Console.ReadLine();
                ValidateEmail = PatternClass.ValidateEmail(this.Email);
                DisplayOutput("Email", ValidateEmail);
            } while (!ValidateEmail);
        }
        public void TakePhoneNumber()
        {
            do
            {
                Console.WriteLine("Enter Phone Number: ");
                this.PhoneNumber = Console.ReadLine();
                ValidatePhoneNumber = PatternClass.ValidatePhone(this.PhoneNumber);
                DisplayOutput("PhoneNumber", ValidatePhoneNumber);
            } while (!ValidatePhoneNumber);
        }
        public void TakePassword()
        {
            do
            {
                Console.WriteLine("Enter Password: ");
                this.Password = Console.ReadLine();
                ValidatePassword = PatternClass.ValidatePassword(this.Password);
                DisplayOutput("Password", ValidatePassword);
            } while (!ValidatePassword);
        }

        public void DisplayOutput(string option, bool Validate)
        {
            if(Validate)
            {
                Console.WriteLine("Input entered is valid");
            }
            else
            {
                Console.WriteLine("Input entered is Invalid");
                DisplayRules(option);
            }
        }

        public void DisplayRules(string option)
        {
            switch (option)
            {
                case "FirstName": Console.WriteLine("Enter with Captial case and total length minimum of three characters");
                    break;
                case "LastName":
                    Console.WriteLine("Enter with Captial case and total length minimum of three characters");
                    break;
                case "PhoneNumber":
                    Console.WriteLine("Enter with Country code of 2-digits and 10 digits of number");
                    break;
                case "Password":
                    Console.WriteLine("Enter with atleast one Upper case, numeric, and special symbol with total length minimum of eight characters");
                    break;
                case "Email":
                    Console.WriteLine("Email input is Invalid.");
                    break;
            }

        }

    }
}
