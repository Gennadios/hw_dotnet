
namespace FlightCheckin.Entities
{
    class Ticket
    {
        internal bool IsValid { get; set; }
        internal byte AllowedNumberOfLuggage { get; set; }
        internal byte AllowedNumberOfHandLuggage { get; set; }
        internal byte MaxWeight { get; set; }
        internal byte OverweightFee { get; set; }
        internal byte ExcessBaggageFee { get; set; }

        public Ticket()
        {
            AllowedNumberOfLuggage = 2;
            AllowedNumberOfHandLuggage = 1;
            MaxWeight = 23;
            OverweightFee = 50;
            ExcessBaggageFee = 75;
        }
    }
}
