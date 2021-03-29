using System;
using System.Text.RegularExpressions;

namespace FlightCheckin
{
    static class Validator
    {
        internal static bool ValidateName(string name)
        {
            for (int i = 0; i <= name.Length - 1; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    Console.WriteLine("Sorry, input can only contain letters and can't be empty. Please, try again.");
                    return false;
                }
            }
            return true;
        }

        internal static bool ValidateYesNo(string input)
        {
            if (!input.ToUpper().Equals("Y") && !input.Equals("N"))
                return false;

            return true;
        }

        internal static bool ValidateDate(string dateAsString)
        {
            string pattern = @"^\d{2}\.\d{2}\.\d{4}$";

            bool dateIsValid = DateTime.TryParse(dateAsString, out DateTime validDate);

            if (Regex.IsMatch(dateAsString, pattern) && dateIsValid)
                return true;

            return false;
        }
    }
}
