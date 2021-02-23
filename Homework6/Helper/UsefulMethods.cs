using System;

namespace Helper
{
    public sealed class UsefulMethods
    {
        public static int[] CreateCustomSizeIntArray()
        {
            int arraySize;
            while (true)
            {
                Console.Write("Please, input size of array (should be more than 0): ");
                string userInput = Console.ReadLine();
                bool arraySizeMakesSense = int.TryParse(userInput, out arraySize);

                if (arraySizeMakesSense && arraySize > 0)
                    break;
                else
                    Console.WriteLine("The input was incorrect. Please, try again.");
            }

            return new int[arraySize];
        }
        public static void InputArrayElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write("Please, input element #" + i + ":");
                    string userNum = Console.ReadLine();
                    bool inputIsNumber = int.TryParse(userNum, out array[i]);

                    if (inputIsNumber)
                        break;
                    else
                        Console.WriteLine("Please, try again. Input should be a number.");
                }
            }
        }

        public static void PrintArrayElements(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.Write(array[i] + "]");
                else
                    Console.Write(array[i] + ", ");
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
