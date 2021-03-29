using System;

namespace Task1
{
    public static class Validator
    {
        internal static double GetPositiveDouble(string request)
        {
            Console.Write(request);
            double data;
            while(true)
            {
                string userInput = Console.ReadLine();
                bool dataIsValid = double.TryParse(userInput, out data);

                if (dataIsValid && data > 0)
                    break;
                else
                    Console.WriteLine("Sorry, this is not a valid input.");
            }
            return data;
        }

        internal static int GetValidYear(string request)
        {
            Console.Write(request);
            int year;
            while (true)
            {
                string userInput = Console.ReadLine();
                bool yearIsValid = int.TryParse(userInput, out year);

                if (yearIsValid && year < DateTime.Now.Year)
                    break;
                else
                    Console.WriteLine("Sorry, this is not a valid input");
            }
            return year;
        }

        internal static string GetValidName(string request)
        {
            Console.Write(request);
            string name;
            while (true)
            {
                name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name) && NameHasLettersOnly(name))
                    break;
                else
                    Console.WriteLine("Sorry, this is not a valid name.");
            }

            return name;
        }

        static bool NameHasLettersOnly(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]) && !Char.IsWhiteSpace(name[i]))
                    return false;
            }
            return true;
        }
    }
}
