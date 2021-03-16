using FlightCheckin.Entities;
using System.Text;


namespace FlightCheckin
{
    class Passenger
    {
        internal Passport passport = new Passport();
        internal Ticket ticket = new Ticket();
        internal BoardingPass boardingPass;
        internal Baggage baggage = new Baggage();

        internal string Name { get; set; }
        internal string MiddleName { get; set; }
        internal string Lastname { get; set; }
        internal string FullName
        {
            get
            {
                StringBuilder sb = new StringBuilder(Name);

                if (string.IsNullOrEmpty(MiddleName))
                    sb.Append(" " + Lastname);
                else
                    sb.Append($" {MiddleName} {Lastname}");

                return sb.ToString();
            }
        }
        internal bool HasPassport { get; set; }
        internal bool HasValidTicket { get; set; }
        internal bool HasCheckedIn { get; set; }
        internal bool HasBaggage
        { 
            get
            {
                if (baggage.NumberOfCases == 0 && baggage.NumberOfHandLuggage == 0)
                    return false;
                return true;
            }
        }
        internal int SuspiciousBehaviour { get; set; }

        internal void SetPassportNameInfo()
        {
            passport.Name = Name;
            passport.MiddleName = MiddleName;
            passport.Lastname = Lastname;
        }
    } 
}
