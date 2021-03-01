using System;
using System.Text;

namespace HW._07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string abracadabra = "gdfgdf234dg54gf*23oP42";

            Console.WriteLine(DecipherArithmetics(abracadabra)); 
        }
        static double DecipherArithmetics(string text)
        {
            char operation = '\0';
            string stringNum1 = string.Empty;
            string stringNum2 = string.Empty;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    sb.Append(text[i]);
                }
                if (text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/')
                {
                    operation = text[i];
                    if (string.IsNullOrEmpty(stringNum1))
                    {
                        stringNum1 = sb.ToString();
                        sb.Clear();
                    }
                }
            }
            stringNum2 = sb.ToString();
            sb.Clear();

            int num1 = int.Parse(stringNum1);
            int num2 = int.Parse(stringNum2);

            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return 0;
            }
        }
    }
}
