using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers();
        }

        static void AddTwoNumbers()
        {
            try
            {
                Console.WriteLine("Please, input an integer: ");
                int userNum1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input another integer: ");
                int userNum2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{userNum1} + {userNum2} = {userNum1 + userNum2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, you entered an invalid value (should be an integer). Please, try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sorry, your integer should be more than -2147483647 and less than 2147483647. \nPlease, try again.");
            }
        }
    }
}
