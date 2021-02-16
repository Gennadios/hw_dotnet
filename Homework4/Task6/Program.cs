using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveWithConsoleKey();
        }

        static void MoveWithConsoleKey()
        {
            Console.WriteLine("Please, move using direction keys (W, A, S or D)");

            ConsoleKey inputKey = Console.ReadKey().Key;
            switch (inputKey)
            {
                case ConsoleKey.W:
                    Console.WriteLine("\nYou move forward.");
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("\nYou move left.");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("\nYou move backwards.");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("\nYou move right.");
                    break;
                default:
                    Console.WriteLine("\nYou are standing still.");
                    break;
            }
        }
        // alternative solution
        static void MoveWithConsoleReadLine()
        {
            Console.WriteLine("Please, move input a direction key <W, A, S or D> to move and press enter");

            string userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "W":
                    Console.WriteLine("You move forward.");
                    break;
                case "A":
                    Console.WriteLine("You move left.");
                    break;
                case "S":
                    Console.WriteLine("You move backward.");
                    break;
                case "D":
                    Console.WriteLine("You move right.");
                    break;
                default:
                    Console.WriteLine("You are standing still.");
                    break;
            }
        }
    }
}
