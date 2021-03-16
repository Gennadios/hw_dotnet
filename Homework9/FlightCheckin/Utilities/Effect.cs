using System;
using System.Threading;

namespace FlightCheckin.Utilities
{
    static class Effect
    {
        internal static void ImitateLoading(int seconds)
        {
            for(int i = 0; i < seconds; i++)
            {
                Console.Write("*\t\t");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        internal static void PressAnyKey(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
