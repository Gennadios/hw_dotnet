using FlightCheckin.Entities;
using FlightCheckin.Utilities;
using System;


namespace FlightCheckin.Actions
{
    class CheckIn
    {
        int excessWeightLuggage;
        int numberOfExcessLuggage;
        int extraFees;

        internal static void Commence(Passenger passenger)
        {
            CheckIn checkIn = new CheckIn();

            Console.WriteLine("You proceed to check in counter");

            if (!passenger.HasCheckedIn && passenger.HasBaggage)
            {
                CheckTicket(passenger);
                GiveBoardingPass(passenger);
                CheckHandLuggage(passenger);
                CheckCases(passenger);
                checkIn.CalculateFees(passenger);
                checkIn.CollectFees();
            }
            else if (!passenger.HasCheckedIn && !passenger.HasBaggage)
            {
                CheckTicket(passenger);
                GiveBoardingPass(passenger);
            }

            else
            {
                Console.WriteLine("As you have already checked in, we only need to check your baggage.");
                CheckHandLuggage(passenger);
                CheckCases(passenger);
                checkIn.CalculateFees(passenger);
                checkIn.CollectFees();
            }

            Console.WriteLine("All done. Please, proceed to Passport Control.");
            Effect.ImitateLoading(5);
        }

        static void CheckTicket(Passenger passenger)
        {
            Console.WriteLine("As you haven't registered for the flight yet, I need to check your information.");
            passenger.HasValidTicket = AirportService.YesNoQuestion("Do you have a ticket?");
            while (!passenger.HasValidTicket)
            {
                Console.WriteLine("Please, double check or buy a ticket here at the airport. There still are free seats.");
                passenger.HasValidTicket = AirportService.YesNoQuestion("Did you manage to find or buy a ticket?");
            }

            Console.WriteLine("Let me see your passport and ticket, please.");
            Effect.ImitateLoading(5);
            Console.WriteLine("Everything is ok, you are in the passenger list.");
        }

        static void GiveBoardingPass(Passenger passenger)
        {
            Console.WriteLine("Here is your boarding pass.");
            passenger.boardingPass = new BoardingPass();
            Console.WriteLine($"Your gate is {passenger.boardingPass.Gate} and your seat number is {passenger.boardingPass.SeatNumber}.");
            passenger.HasCheckedIn = true;
        }

        static void CheckHandLuggage(Passenger passenger)
        {
            if (passenger.baggage.NumberOfHandLuggage != 0)
            {
                Console.WriteLine("First, let's see if your carry on baggage meets the air company weight restrictions.");

                passenger.baggage.HandLuggageWeight = GenerateRandomWeight(5, 12);
                if (passenger.baggage.HandLuggageWeight > 10)
                {
                    Console.WriteLine($"Your bag weight is {passenger.baggage.HandLuggageWeight}, which exceeds the air company max weight restriction for hand luggage." +
                                       "You'll have to register it as ordinary baggage.");
                    passenger.baggage.NumberOfHandLuggage--;
                }
                else
                    Console.WriteLine($"Your bag weight is {passenger.baggage.HandLuggageWeight} kg, so you may take it to the aircraft.");
                
                Effect.PressAnyKey("(press any key to continue)");
            }
        }

        static void CheckCases(Passenger passenger)
        {
            if (passenger.baggage.NumberOfCases != 0)
            {
                Console.WriteLine("Please, put your luggage on the scales.");

                passenger.baggage.CasesWeights = new int[passenger.baggage.NumberOfCases];

                for (int i = 0; i < passenger.baggage.CasesWeights.Length; i++)
                {
                    Console.WriteLine($"You put case #{i + 1} on the scales.");
                    passenger.baggage.CasesWeights[i] = GenerateRandomWeight(15, 25);
                    Console.WriteLine($"Case #{i + 1} weight is {passenger.baggage.CasesWeights[i]} kg");
                    Effect.PressAnyKey("(press any key to continue)");
                }
            }
        }

        void SetExcessLuggage(Passenger passenger)
        {
            int actualBaggage = passenger.baggage.NumberOfCases;
            if (passenger.baggage.HandLuggageWeight > 10)
                actualBaggage++;

            numberOfExcessLuggage = actualBaggage - passenger.ticket.AllowedNumberOfLuggage;
            if (numberOfExcessLuggage < 0)
                numberOfExcessLuggage = 0;
        }

        void SetExcessWeightLuggage(Passenger passenger)
        {
            if (passenger.baggage.CasesWeights != null)
            {
                int count = 0;
                for (int i = 0; i < passenger.baggage.CasesWeights.Length; i++)
                {
                    if (passenger.baggage.CasesWeights[i] > passenger.ticket.MaxWeight)
                        count++;
                }
                excessWeightLuggage = count;
            }
        }

        void CalculateFees(Passenger passenger)
        {
            SetExcessLuggage(passenger);
            SetExcessWeightLuggage(passenger);

            extraFees = excessWeightLuggage * passenger.ticket.OverweightFee + numberOfExcessLuggage * passenger.ticket.ExcessBaggageFee;
        }

        void ExtraFeesWarning()
        {
            Console.WriteLine($"Unfortunately you will have to pay extra for {excessWeightLuggage} overweight case(s) and " +
                              $"{numberOfExcessLuggage} excess luggage");
            Console.WriteLine($"The amount of extra fees is {extraFees} USD.");
        }

        void CollectFees()
        {
            if (extraFees != 0)
            {
                ExtraFeesWarning();
                Effect.PressAnyKey("(press any key to pay the extra fee)");
                Console.WriteLine($"Not much of a choice: you open your wallet and hand ${extraFees} to the air company employee.");
            }
        }

        static int GenerateRandomWeight(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }
    }
}
