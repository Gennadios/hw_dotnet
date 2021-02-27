using System;
using System.Text;

namespace HW._07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is a test string. It will be changed with method I'll code later.";
            DeleteLongestWord(testString);

            Console.WriteLine(" *** Task 1 *** ");
            Console.WriteLine("Removing the longest word from testString: ");
            Console.WriteLine($"Original text: \"{testString}\"");
            Console.WriteLine($"Text after removing the longest word: \"{DeleteLongestWord(testString)}\"");
            Console.WriteLine();

            Console.WriteLine(" *** Task 2 *** ");
            Console.WriteLine("Swapping the longest and shortest words in testString: ");
            Console.WriteLine($"Original text: \"{testString}\"");
            Console.WriteLine($"Text after swap: {SwapLongestAndShortest(testString)}");
            Console.WriteLine();

            Console.WriteLine(" *** Task 3 *** ");
            Console.WriteLine("Getting number of letters and punctuation chars in testString: ");
            GetNumOfChars(testString);

            Console.WriteLine(" *** Task 4 *** ");
            Console.WriteLine("Turning testString into a one-dimensional array and sorting elements from longest to shortest: ");
            string[] descendingStrings = SortByLengthDescending(testString);
            for (int i = 0; i < descendingStrings.Length; i++)
                Console.WriteLine($"Element {i}: {descendingStrings[i]}");
        }

        // additional method to get length of word without punctuation at the end of a word
        static int GetRealLength(string word)
        {
            StringBuilder sb = new StringBuilder(word);

            char lastChar = word[word.Length - 1];
            int realLength;
            while(Char.IsPunctuation(lastChar))
            {
                sb.Remove(word.Length - 1, 1);
                word = sb.ToString();
                lastChar = word[word.Length - 1];
            }
            realLength = sb.ToString().Length;

            return realLength;
        }

        static string DeleteLongestWord(string text)
        {
            string[] strArray = text.Split(' ');

            int maxLength = new int();
            string longestWord = string.Empty;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (GetRealLength(strArray[i]) > maxLength)
                {
                    longestWord = strArray[i];
                    maxLength = GetRealLength(longestWord);
                }       
            }
            
            return text.Replace(longestWord, string.Empty);
        }

        static string SwapLongestAndShortest(string text)
        {
            string[] strArray = text.Split(' ');

            string longestWord = string.Empty;
            int longestIdx = new int();
            int maxLength = new int();
            string shortestWord = text;
            int shortestIdx = new int();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (GetRealLength(strArray[i]) > maxLength)
                {
                    longestWord = strArray[i];
                    longestIdx = i;
                    maxLength = GetRealLength(strArray[i]);
                }

                if (GetRealLength(strArray[i]) < GetRealLength(shortestWord))
                {
                    shortestWord = strArray[i];
                    shortestIdx = i;
                }
            }

            string temp = shortestWord;
            strArray[shortestIdx] = strArray[longestIdx];
            strArray[longestIdx] = shortestWord;

            return String.Join(' ', strArray);
        }

        static void GetNumOfChars(string text)
        {
            int numOfLetters = new int();
            int numOfPunct = new int();

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                    numOfLetters++;
                else if (Char.IsPunctuation(text[i]))
                    numOfPunct++;
            }
            Console.WriteLine($"Number of letters: {numOfLetters}");
            Console.WriteLine($"Number of punctuation characters: {numOfPunct}");
        }

        static string[] SortByLengthDescending(string text)
        {
            string[] strArray = text.Split(' ');

            int maxLength = new int();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > maxLength)
                    maxLength = strArray[i].Length;
            }

            int len = strArray.Length;
            string[] sortedArr = new string[len];
            int index = 0;
            while (index < len)
            {
                for (int i = 0; i < len; i++)
                {
                    if (strArray[i].Length == maxLength)
                    {
                        sortedArr[index] = strArray[i];
                        index++;
                    }
                }
                maxLength--;
            }

            return sortedArr;
        }
    }
}
