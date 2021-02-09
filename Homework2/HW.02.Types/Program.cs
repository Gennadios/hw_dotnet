using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            Boolean isFalse = false;
            Console.WriteLine($"Type of bool isTrue variable: {isTrue.GetType()}");
            Console.WriteLine($"Type of System.Boolean isFalse variable: {isFalse.GetType()}");
            Console.WriteLine();

            byte keyByte = 255;
            Byte netByte = 0;
            Console.WriteLine($"Type of byte keyByte variable: {keyByte.GetType()}");
            Console.WriteLine($"Type of System.Byte netByte variable: {netByte.GetType()}");
            Console.WriteLine();

            sbyte keySbyte = -100;
            SByte netSbyte = 100;
            Console.WriteLine($"Type of sbyte keySbyte variable: {keySbyte.GetType()}");
            Console.WriteLine($"Type of System.SByte netSbyte variable: {netSbyte.GetType()}");
            Console.WriteLine();

            char keyChar = 'a';
            Char netChar = 'z';
            Console.WriteLine($"Type of char keyChar variable: {keyChar.GetType()}");
            Console.WriteLine($"Type of System.Char netChar variable: {netChar.GetType()}");
            Console.WriteLine();

            decimal keyDecimal = 1.2345m;
            Decimal netDecimal = 6.7891m;
            Console.WriteLine($"Type of decimal keyDecimal variable: {keyDecimal.GetType()}");
            Console.WriteLine($"Type of System.Decimal netDecimal variable: {netDecimal.GetType()}");
            Console.WriteLine();

            double keyDouble = 1.234;
            Double netDouble = 5.6789;
            Console.WriteLine($"Type of double keyDouble variable: {keyDouble.GetType()}");
            Console.WriteLine($"Type of System.Double netDouble variable: {netDouble.GetType()}");
            Console.WriteLine();

            float keyFloat = 1.23f;
            Single netFloat = 4.56f;
            Console.WriteLine($"Type of float keyFloat variable: {keyFloat.GetType()}");
            Console.WriteLine($"Type of System.Single netFloat variable: {netFloat.GetType()}");
            Console.WriteLine();

            int keyInt = 1000000000;
            Int32 netInt = -1000000000;
            Console.WriteLine($"Type of int keyInt variable: {keyInt.GetType()}");
            Console.WriteLine($"Type of System.Int32 netInt variable: {netInt.GetType()}");
            Console.WriteLine();

            uint keyUint = 0;
            UInt64 netUint = 3000000000000000000;
            Console.WriteLine($"Type of uint keyUint variable: {keyUint.GetType()}");
            Console.WriteLine($"Type of System.UInt64 netUint variable: {netUint.GetType()}");
            Console.WriteLine();

            long keyLong = 9223372036854775807;
            Int64 netLong = -9223372036854775808;
            Console.WriteLine($"Type of long keyLong variable: {keyLong.GetType()}");
            Console.WriteLine($"Type of System.Int64 netLong variable: {netLong.GetType()}");
            Console.WriteLine();

            ulong keyUlong = 0;
            UInt64 netUlong = 18446744073709551615;
            Console.WriteLine($"Type of ulong keyUlong variable: {keyUlong.GetType()}");
            Console.WriteLine($"Type of System.UInt64 netUlong variable: {netUlong.GetType()}");
            Console.WriteLine();

            short keyShort = 32767;
            Int16 netShort = -32768;
            Console.WriteLine($"Type of short keyShort variable: {keyShort.GetType()}");
            Console.WriteLine($"Type of System.Int16 netShort variable: {netShort.GetType()}");
            Console.WriteLine();

            ushort keyUshort = 0;
            UInt16 netUshort = 65535;
            Console.WriteLine($"Type of ushort keyUshort variable: {keyUshort.GetType()}");
            Console.WriteLine($"Type of System.UInt16 netUshort variable: {netUshort.GetType()}");
            Console.WriteLine();

            string keyString = "Hello";
            String netString = "Guten abend";
            Console.WriteLine($"Type of string keyString variable: {keyString.GetType()}");
            Console.WriteLine($"Type of System.String netString variable: {netString.GetType()}");
            Console.WriteLine();

            object keyObj = new object();
            Object netObj = new object();
            Console.WriteLine($"Type of object keyObj variable: {keyObj.GetType()}");
            Console.WriteLine($"Type of System.Object netObj variable: {netObj.GetType()}");
            Console.WriteLine();
        }
    }
}
