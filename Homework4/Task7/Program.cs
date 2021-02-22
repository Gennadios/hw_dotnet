using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse vs TryParse with Int32
            // Parse
            Console.WriteLine("*** Comparing Parse and TryParse at the example of Int32 ***");
            string parseStr1 = "12";
            int parseInt = int.Parse(parseStr1);
            Console.WriteLine($"parseStr1 = {parseStr1}, therefore we managed to parse our parseStr1 for an integer and can move on. \n" +
                               "Had we not managed to convert from string to int, an exception would've been thrown.\n");
            // tryParse
            string tpStr1 = "twelve";
            int tpInt = default;
            Console.WriteLine($"tpStr = {tpStr1}, let's try to parse this value for integer with TryParse.");
            bool tpStrValidation = int.TryParse(tpStr1, out tpInt);
            if (tpStrValidation)
                Console.WriteLine("Successfully converted tpstr to an integer.");
            else
                Console.WriteLine("Failed to convert tpStr to an integer.\n" +
                                  "tpInt is now 0");

            Console.WriteLine("But we still managed to get to the end of this code.\n" +
                              "Press Enter to continue...");
            Console.ReadLine();

            // Parse vs TryParse with Char
            // Parse
            Console.WriteLine("*** Comparing Parse and TryParse at the example of Char ***");
            string parseStr2 = "k";
            char parseChar = char.Parse(parseStr2);
            Console.WriteLine($"parseStr2 = {parseStr2}, therefore we can parse for char and move on.\n");

            // TryParse
            Console.WriteLine("Now let's use TryParse.");
            string tpStr2 = "sym";
            char tpChar = 'x';
            bool tryChar = char.TryParse(tpStr2, out tpChar);
            Console.WriteLine("tpChar variable was initially assigned the value of 'x', but as tryChar is false, tpChar now equals '\0' (which is default)\n" +
                              "Press Enter to continue...");
            Console.ReadLine();

            // Parse vs TryParse with Boolean
            // Parse
            Console.WriteLine("*** Comparing Parse and TryParse at the example of Boolean ***");
            string parseStr3 = "true";
            bool parseBool = bool.Parse(parseStr3);
            Console.WriteLine($"parseStr3 = {parseStr3}, therefore we can parse for bool and move on.\n");

            // TryParse
            Console.WriteLine("Now let's check out TryParse.");
            string tpStr3 = "fols";
            bool tpBool = true;
            bool tryBool = bool.TryParse(tpStr3, out tpBool);
            Console.WriteLine("tpBool is initially assigned with true, but as we fail to parse a Boolean value from tpStr3 which equals 'fols', tpBool turns false in the end.");
        }
    }
}
