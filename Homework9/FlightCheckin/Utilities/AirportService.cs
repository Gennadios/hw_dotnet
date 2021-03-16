using System;

namespace FlightCheckin
{
    static class AirportService
    {
        internal const string AirportName = "Vnukovo Airport";

        internal static string GetNameInput(string message)
        {
            Console.Write(message);

            string userInput = Console.ReadLine(); ;
            while (!Validator.ValidateName(userInput) || string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Sorry, but input cannot contain numbers or be empty.");
                Console.Write(message);
                userInput = Console.ReadLine();
            }
            
            return userInput;
        }

        internal static string GetPassengerMiddleName()
        {
            string userMiddleName;

            if (YesNoQuestion("Do you have a middle name?"))
                userMiddleName = GetNameInput("Middle name: ");
            else
                userMiddleName = string.Empty;

            return userMiddleName;
        }

        internal static DateTime GetDateInput(string request)
        {
            Console.Write(request + " (format: DD.MM.YYYY):");

            string dateAsString = Console.ReadLine();
            while(!Validator.ValidateDate(dateAsString))
            {
                Console.WriteLine("Sorry, but input is incorrect. Please, try again.");
                Console.Write(request + " (format: DD.MM.YYYY):");
                dateAsString = Console.ReadLine();
            }

            return DateTime.Parse(dateAsString);
        }

        internal static bool YesNoQuestion(string question)
        {
            Console.Write(question + " [y/n] ");

            string userInput = Console.ReadLine();
            while (!Validator.ValidateYesNo(userInput.ToUpper()))
            {
                Console.WriteLine("Sorry, but input is incorrect.");
                Console.Write(question + " [y/n] ");
                userInput = Console.ReadLine();
            }

            return userInput.ToUpper().Equals("Y"); 
        }

        internal static void ProvideGuidance(Passenger passenger)
        {
            if(passenger.HasCheckedIn && !passenger.HasBaggage)
                Console.WriteLine("Great! You can directly proceed to Passport Control.");
            else if(passenger.HasCheckedIn && passenger.HasBaggage)
                Console.WriteLine("Ok. You may proceed to check in counter to check you luggage.");
            else
                Console.WriteLine("Ok. Please, proceed to check in counter to register for the flight.");
        }

        internal static void CheckForCriticalCondition(bool condition, string exitMessage)
        {
            if (!condition)
            {
                Console.WriteLine(exitMessage);
                Environment.Exit(0);
            }
        }

        internal static void InitialMessage(Passenger passenger)
        {
            if (!passenger.HasBaggage)
                Console.WriteLine("You arrive at the airport without any baggage.");
            else
                Console.WriteLine($"You arrive at the airport with {passenger.baggage.NumberOfCases} case(s) and {passenger.baggage.NumberOfHandLuggage} hand bag(s).");
        }
    }
}
