using System;
using FlightCheckin.Utilities;

namespace FlightCheckin.Actions
{
    class SecurityCheck
    {
        internal static void Commence(Passenger passenger)
        {
            Console.WriteLine("You finally get to Security Check.");
            CheckPassenger(passenger);

            Console.WriteLine("It is finally over! Have a nice flight.");
        }

        static void CheckPassenger(Passenger passenger)
        {
            if (passenger.baggage.NumberOfHandLuggage == 0)
            {
                Console.WriteLine("As you don't have hand luggage, it won't take too long ...");
                Effect.ImitateLoading(5);
            }
            else
            {
                Console.WriteLine("You have a laptop in your carry on bag. And maybe water. And probably something else. It might take a while...");
                Effect.ImitateLoading(5);
                Effect.ImitateLoading(5);
                Effect.ImitateLoading(5);
            }
        }
    }
}
