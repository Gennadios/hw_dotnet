using System;

namespace HW03.Calculator.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Getting numerical values with Convert.ToInt32 ***");
            Console.WriteLine("Please, input the first number: ");
            int convertedNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, input the second number: ");
            int convertedNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{convertedNum1} + {convertedNum2} = {StatiсCalculator.Add(convertedNum1, convertedNum2)}");
            Console.WriteLine($"{convertedNum1} - {convertedNum2} = {StatiсCalculator.Subtract(convertedNum1, convertedNum2)}");
            Console.WriteLine($"{convertedNum1} * {convertedNum2} = {StatiсCalculator.Multiply(convertedNum1, convertedNum2)}");
            Console.WriteLine();

            Console.WriteLine("*** Getting numerical values with int.Parse ***");
            Console.WriteLine("Please, input the first number: ");
            int parsedNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, input the second number: ");
            int parsedNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{parsedNum1} / {parsedNum2} = {StatiсCalculator.Divide(parsedNum1, parsedNum2)}");
            Console.WriteLine($"{parsedNum1} % {parsedNum2} = {StatiсCalculator.Remainder(parsedNum1, parsedNum2)}");

            Console.WriteLine("Please, input radius of the circumference: ");
            int circleRadius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Area of the circle is: {StatiсCalculator.CircleArea(circleRadius)}");
        }
    }

    public static class StatiсCalculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(int num1, int num2)
        {
            return (double)num1 / num2;
        }

        public static int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }

        public static double CircleArea(double radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
