using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class PatternClass
    {
        public static string FirstNamePattern = "^[A-Z][a-z]{2,}$";
        public static string MobilePattern = "^[0-9]{2}\\s[0-9]{10}$";
        public static string EmailPattern = "^\\S+(\\.\\S+)?@\\S+\\.\\S+(\\.\\S+)?";
        public static string PasswordPattern = "^(?=.*?[A-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public static bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FirstNamePattern);
        }
        public static bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, FirstNamePattern);
        }
        public static bool ValidatePhone(string Mobile)
        {
            return Regex.IsMatch(Mobile, MobilePattern);
        }
        public static bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, EmailPattern);
        }
        public static bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, PasswordPattern);
        }
    }
}
