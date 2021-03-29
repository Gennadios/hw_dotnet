using System;

namespace FlightCheckin.Entities
{
    class BoardingPass
    {
        internal byte Gate { get; set; }
        internal string SeatNumber { get; set; }
        
        public BoardingPass()
        {
            Gate = GenerateGateNumber();
            SeatNumber = GenerateSeatNumber();
        }

        static byte GenerateGateNumber()
        {
            Random rand = new Random();

            return (byte)rand.Next(1, 51);
        }

        static string GenerateSeatNumber()
        {
            Random rand = new Random();

            int capitalA = 65;
            int capitalF = 70;
            int numberOfRows = 40;

            char letter = (char)rand.Next(capitalA, capitalF + 1);
            string number = rand.Next(1, numberOfRows + 1).ToString();

            return letter.ToString() + number;
        }
    }
}
