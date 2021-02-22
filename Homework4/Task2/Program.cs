using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckSum();
        }

        static void CheckSum()
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

                if(userAnswer == (userNum1 + userNum2))
                    Console.WriteLine("Correct! Well done.");
                else
                    Console.WriteLine("Oops, that's incorrect. Please, try again.");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, you entered an invalid value. Please, try again.");
            }
        }
    }
}
