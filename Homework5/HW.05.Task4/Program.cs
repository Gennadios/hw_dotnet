using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            LettersCount();
        }

        static void LettersCount()
        {
            HW._05.Task3.Program.GoodDay();
            Console.Write("Please, input a word and we'll count how many 'A' letters there are in it: ");
            string userWord = Console.ReadLine().ToLower();

            int count = 0;
            for (int i = 0; i < userWord.Length; i++)
            {
                if (userWord[i] == 'a' || userWord[i] == 'а')
                    count++;
            }
            Console.WriteLine($"There are -{count}- A's in this word.");
        }
    }
}
