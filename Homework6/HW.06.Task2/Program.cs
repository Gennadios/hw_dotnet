using System;
using Helper;

namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Необходимо: заполнить вводом с клавиатуры численный массив за исключением последнего элемента, 
             * вывести его на экран. Запросить еще одно значение и его позицию в в массиве. 
             * Вставить указанное число в заданную позицию, подвинув элементы после него.*/

            int[] arr = UsefulMethods.CreateCustomSizeIntArray();

            Console.WriteLine("Assigning values to all array elements except for the last one: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                while (true)
                {
                    Console.Write("Please, input element #" + i + ":");
                    string userNum = Console.ReadLine();
                    bool inputIsNumber = int.TryParse(userNum, out arr[i]);

                    if (inputIsNumber)
                        break;
                    else
                        Console.WriteLine("Please, try again. Input should be a number.");
                }
            }

            Console.WriteLine("Array before insertion of new element: ");
            UsefulMethods.PrintArrayElements(arr);
            Console.WriteLine();

            Console.Write("Please input the element you want to insert into the array: ");
            int newElement = int.Parse(Console.ReadLine());
            Console.Write("And new element position: ");
            int newElementPos = int.Parse(Console.ReadLine());
            ShiftElements(arr, newElementPos, newElement);
            Console.WriteLine("Array after insertion of new element: ");
            UsefulMethods.PrintArrayElements(arr);

        }

        static void ShiftElements(int[] array, int elementIndex, int value)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            for (int i = elementIndex; i < array.Length - 1; i++)
            {
                array[i + 1] = newArray[i];
            }
            array[elementIndex] = value;
        }
    }
}
