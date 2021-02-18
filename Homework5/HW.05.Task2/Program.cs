using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumTriangle();
        }

        static void NumTriangle()
        {
            int num;
            while(true)
            {
                Console.Write("Please, input any number from 1 to 100: ");
                string userInput = Console.ReadLine();
                bool inputIsParseable = int.TryParse(userInput, out num);

                if (inputIsParseable && num <= 100)
                    break;
                else
                    Console.WriteLine("Sorry, but your input is incorrect. Please, try again.");
            }
            
            string indent = " ";
            for (int i = 1, lineLimit = num; i <= num; i++, lineLimit--)
            {
                for (int j = 1; j <= lineLimit; j++)
                    Console.Write(" " + i % 10);

                Console.WriteLine();
                Console.Write(indent);
                indent += " ";
            }
        }
    }
}
