using System;
using FlightCheckin.Utilities;

namespace FlightCheckin
{
    class Passport
    {
        internal string Name { get; set; }
        internal string MiddleName { get; set; }
        internal string Lastname { get; set; }
        internal string Number { get; set; }
        internal bool IsBiometric { get; set; }
        internal DateTime DateOfIssue { get; set; }
        internal DateTime DateOfExpiry
        { 
            get
            {
                if (IsBiometric)
                    return DateOfIssue.AddYears(10);
                else
                    return DateOfIssue.AddYears(5);
            }
        }
        internal bool IsValid 
        { 
            get
            {
                if (DateOfExpiry < DateTime.Now)
                    return false;
                return true;
            }
        }
        internal bool HasValidVisa { get; set; }

        string GeneratePassportNumber()
        {
            Random rand = new Random();

            return $"МР{rand.Next(1000000, 9999999)}";
        }

        internal void InitializePassportInfo()
        {
            Number = GeneratePassportNumber();
            DateOfIssue = AirportService.GetDateInput("Passport Date Of Issue");
            IsBiometric = AirportService.YesNoQuestion("Is your passport biometric?");
            HasValidVisa = AirportService.YesNoQuestion("Do you have a valid visa?");
        }
        internal void ShowPassport()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Middle Name: {MiddleName}");
            Console.WriteLine($"Lastname: {Lastname}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Date Of Issue: {DateOfIssue.ToShortDateString()}");
            Console.WriteLine($"Date Of Expiry: {DateOfExpiry.ToShortDateString()}");
            Console.WriteLine($"Has valid visa: {HasValidVisa}");
        }
    }
}
