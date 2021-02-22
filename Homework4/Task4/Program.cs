using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckAddOrSubtract();
        }

        static void CheckAddOrSubtract()
        {
            try
            {
                Console.WriteLine("Please, input an integer: ");
                int userNum1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input another integer: ");
                int userNum2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input an operator ('+' or '-'): ");
                string userOperation = Console.ReadLine();

                int correctAnswer = new int();

                switch (userOperation)
                {
                    case "+":
                        correctAnswer = userNum1 + userNum2;
                        Console.Write("Thank you. Now, please input the correct answer: \n" +
                                     $"{userNum1} + {userNum2} = ");
                        break;
                    case "-":
                        correctAnswer = userNum1 - userNum2;
                        Console.Write("Thank you. Now, please input the correct answer: \n" +
                                     $"{userNum1} - {userNum2} = ");
                        break;
                    default:
                        Console.WriteLine("Sorry, the operator should be either '+' or '-'. Please, try again.");
                        return;
                }
                
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == correctAnswer)
                    Console.WriteLine("Correct! Well done.");
                else
                {
                    if (userAnswer > correctAnswer)
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
