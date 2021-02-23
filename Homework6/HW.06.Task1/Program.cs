using System;
using Helper;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeArrays();
        }

        static void ThreeArrays()
        {
            int[] arrayOfRandoms = UsefulMethods.CreateCustomSizeIntArray();
            Random rand = new Random();
            for (int i = 0; i < arrayOfRandoms.Length; i++)
                arrayOfRandoms[i] = rand.Next(1001);

            int[] customArray = new int[arrayOfRandoms.Length];
            Console.WriteLine("Please, fill the array with numbers: ");
            UsefulMethods.InputArrayElements(customArray);

            int[] arrayOfSum = new int[arrayOfRandoms.Length];
            for (int i = 0; i < arrayOfSum.Length; i++)
                arrayOfSum[i] = arrayOfRandoms[i] + customArray[i];

            Console.WriteLine("Array of random numbers: ");
            UsefulMethods.PrintArrayElements(arrayOfRandoms);
            Console.WriteLine();

            Console.WriteLine("Array of user's numbers: ");
            UsefulMethods.PrintArrayElements(customArray);
            Console.WriteLine();

            Console.WriteLine("And here's an array which sums up respective elements of the two arrays: ");
            UsefulMethods.PrintArrayElements(arrayOfSum);
        }
    }
}
