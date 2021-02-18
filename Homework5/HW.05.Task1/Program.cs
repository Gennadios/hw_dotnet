using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int trySum = SumConsecutiveNums();
            Console.WriteLine(trySum);
        }

        static int SumConsecutiveNums()
        {
            Console.WriteLine("Please, input a positive integer: ");
            string userInput = Console.ReadLine();

            int sum = 0;

            if(int.TryParse(userInput, out int userNum))
            {
                for (int i = 1; i <= userNum; i++)
                {
                    sum += i;
                }
                return sum;
            } 
            else
            {
                Console.WriteLine("Sorry, unable to get an integer value from your input. Returning 0 by default.");
                return userNum;
            }
        }

        // to practice recursion
        static int RecursionSum(int i)
        {
            if (i == 0)
                return 0;
            return i + RecursionSum(i - 1);
        }
    }
}
