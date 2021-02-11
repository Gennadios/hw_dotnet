using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserAge();
        }
        // method to force month number to be in the range from 1 to 12
        public static byte LimitRangeToMonths(byte value)
        {
            if (value < 1)
                return 1;
            else if (value > 12)
                return 12;
            else
                return value;
        }

        public static void GetUserAge()
        {
            try
            {
                Console.WriteLine("Please, input your birth year: ");
                int userBirthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input your birth month: ");
                byte userBirthMonth = byte.Parse(Console.ReadLine());
                userBirthMonth = LimitRangeToMonths(userBirthMonth);

                Console.WriteLine("Please, input current year: ");
                int currentYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input current month: ");
                byte currentMonth = byte.Parse(Console.ReadLine());
                userBirthMonth = LimitRangeToMonths(currentMonth);

                int userAge = new int();
                if(userBirthYear > currentYear)
                {
                    Console.WriteLine("You are not yet born :)");
                }
                else
                {
                    if (currentMonth >= userBirthMonth)
                        userAge = currentYear - userBirthYear;
                    else
                        userAge = currentYear - userBirthYear - 1;

                    Console.WriteLine($"You are {userAge} years old");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
