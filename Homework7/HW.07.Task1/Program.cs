using System;

namespace HW._07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a poem in one line. Use ';' for line breaks: ");
            string userPoem = Console.ReadLine();

            PrintPoem(userPoem);
        }

        static void PrintPoem(string poem)
        {
            string[] poemLines = poem.Split(';');
            foreach (var item in poemLines)
                Console.WriteLine(item);
        }
    }
}
