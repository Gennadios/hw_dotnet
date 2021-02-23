using System;
using Helper;

namespace HW._06.Task3
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before reverse: ");
            UsefulMethods.PrintArrayElements(myArr);
            Console.WriteLine();

            CustomReverse(myArr);
            Console.WriteLine("After reverse: ");
            UsefulMethods.PrintArrayElements(myArr);
        }

        static void CustomReverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            int len = array.Length;

            for (int i = 0; i < len; i++)
                array[i] = newArray[(len - 1 - i)];
        }

        public static void CustomReverse(long[] array)
        {
            long[] newArray = new long[array.Length];
            Array.Copy(array, newArray, array.Length);
            int len = array.Length;

            for (int i = 0; i < len; i++)
                array[i] = newArray[(len - 1 - i)];
        }

        public static void CustomReverse2(long[] array)
        {
            int lastIndex = array.Length - 1;
            int len = array.Length;
            long temp;
            for (int i = 0; i < len/2; i++)
            {
                temp = array[i];
                array[i] = array[lastIndex - i];
                array[lastIndex - i] = temp;
            }
        }
    }
}
