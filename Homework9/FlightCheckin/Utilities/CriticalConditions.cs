using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCheckin.Utilities
{
    static class CriticalConditions
    {
        internal static string noPassport = "Sorry, but you cannot proceed to check in without a valid passport.";
        internal static string invalidPassport = "Sorry, but your passport is invalid, can't let you through.";
        internal static string noValidVisa = "Sorry, but destination country requires a valid visa. Can't let you through.";
        internal static string tooSuspicious = "You're too suspicious. Security, grab this passenger!";
    }
}
