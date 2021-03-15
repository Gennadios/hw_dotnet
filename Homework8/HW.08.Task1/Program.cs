using System;
using System.Text;

namespace HW._08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "1a!2.3!!.. 4.!.?6 7! ..?";
            Console.WriteLine(ModifyString(testString));
        }

        static string ModifyString(string text)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (!sb1.ToString().Contains('?'))
                {
                    if (text[i] != '!' && text[i] != '.')
                        sb1.Append(text[i]);
                }
                else
                    sb2.Append(text[i]);
            }

            sb2.Replace(' ', '_');

            return String.Concat(sb1.ToString(), sb2.ToString());
        }
    }
}
