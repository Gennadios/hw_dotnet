using System;

namespace HW._02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 примера явного преобразования типов
            long expLong = 847194;
            int expInt = (int)expLong;

            decimal expDecimal = 819241.333m;
            double expDouble = (double)expDecimal;

            sbyte expSbyte = 0;
            byte expByte = (byte)expSbyte;

            // 3 примера неявного пребразования типов
            byte impByte = 255;
            int impInt = impByte;

            short impShort = 32767;
            long impLong = impShort;

            float impFloat = 123.456f;
            double impDouble = impFloat;

            // 3 примера операции упаковки (boxing)
            int myNum = 9999;
            object boxNum = myNum;

            char myChar = 'x';
            object boxChar = myChar;

            double myDouble = 3.14159265359;
            object boxDouble = myDouble;

            // 3 примера операции распаковки (unboxing)
            myNum = (int)boxNum;

            myChar = (char)boxChar;

            myDouble = (double)boxDouble;
        }
    }
}
