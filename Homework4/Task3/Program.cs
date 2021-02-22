using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckSumWithHints();
        }

        static void CheckSumWithHints()
        {
            try
            {
                Console.WriteLine("Please, input an integer: ");
                int userNum1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input another integer: ");
                int userNum2 = int.Parse(Console.ReadLine());
                Console.Write("Thank you. Now, please input the correct answer: \n" +
                             $"{userNum1} + {userNum2} = ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == (userNum1 + userNum2))
                    Console.WriteLine("Correct! Well done.");
                else
                {
                    if (userAnswer > (userNum1 + userNum2))
                        Console.WriteLine("Incorrect. Correct answer is lower than the number you entered.");
                    else
                        Console.WriteLine("Incorrect. Correct answer is higher than the number you entered.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, you entered an invalid value. Please, try again.");
            }
        }
    }
}
