using System;
using FlightCheckin.Utilities;

namespace FlightCheckin.Actions
{
    class Greeting
    {
        internal static void Commence(Passenger passenger)
        {
            AirportService.InitialMessage(passenger);
            Effect.ImitateLoading(5);
            Console.WriteLine("Greetings, passenger! Please, introduce yourself.");

            passenger.Name = AirportService.GetNameInput("Name: ");
            passenger.Lastname = AirportService.GetNameInput("Lastname: ");
            passenger.MiddleName = AirportService.GetPassengerMiddleName();
            passenger.SetPassportNameInfo();

            Console.WriteLine($"{passenger.FullName}, welcome to {AirportService.AirportName}!");

            passenger.HasPassport = AirportService.YesNoQuestion("Did you bring your passport?");
            AirportService.CheckForCriticalCondition(passenger.HasPassport, CriticalConditions.noPassport);

            passenger.HasCheckedIn = AirportService.YesNoQuestion("Have you already checked in online?");
            AirportService.ProvideGuidance(passenger);
            Effect.ImitateLoading(5);
        }
    }
}
