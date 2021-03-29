using System;

namespace FlightCheckin.Entities
{
    class Baggage
    {
        internal int NumberOfCases { get; set; }
        internal int[] CasesWeights;
        internal int NumberOfHandLuggage { get; set; }
        internal int HandLuggageWeight { get; set; }
        

        public Baggage()
        {
            Random rand = new Random();

            NumberOfCases = rand.Next(0, 3);
            NumberOfHandLuggage = rand.Next(0, 2);
        }
    }
}
