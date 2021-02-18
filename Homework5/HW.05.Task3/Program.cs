using System;

namespace HW._05.Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            GoodDay2();
        }

        // option 1
        public static void GoodDay()
        {
            int currentHour = DateTime.Now.Hour;

            switch (currentHour)
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Good day, guys!");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine("Good evening, guys!");
                    break;
                default:
                    Console.WriteLine("Good night, guys!");
                    break;
            }
        }

        // option 2
        static void GoodDay2()
        {
            int currentHour = DateTime.Now.Hour;

            switch (currentHour)
            {
                case int h when (h >= 9 && h < 12):
                    Console.WriteLine("Good morning, guys!");
                    break;
                case int h when (h >= 12 && h < 15):
                    Console.WriteLine("Good day, guys!");
                    break;
                case int h when (h >= 12 && h < 22):
                    Console.WriteLine("Good evening, guys!");
                    break;
                default:
                    Console.WriteLine("Good night, guys!");
                    break;
            }
        }
    }
}
