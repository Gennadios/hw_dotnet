using System;
using FlightCheckin.Actions;


namespace FlightCheckin
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();

            Greeting.Commence(passenger);

            if (!passenger.HasCheckedIn || passenger.HasBaggage)
                CheckIn.Commence(passenger);

            PassportControl.Commence(passenger);
            SecurityCheck.Commence(passenger);
        }
    }
}
