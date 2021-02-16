using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int aAsInt = 97; // decimal value of char 'a'
            int zAsInt = 122; // decimal value of char 'z'

            for (int i = zAsInt; i >= aAsInt; i--)
                Console.Write($"{Convert.ToChar(i)}  ");
        }
    }
}
