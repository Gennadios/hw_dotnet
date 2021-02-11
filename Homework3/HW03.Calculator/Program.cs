using System;

namespace HW03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // for the first 3 methods use Convert.ToInt32 to get inputs
            Console.WriteLine("*** Getting numerical values with Convert.ToInt32 ***");
            Console.WriteLine("Please, input the first number: ");
            int convertedNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, input the second number: ");
            int convertedNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{convertedNum1} + {convertedNum2} = {calc.Add(convertedNum1, convertedNum2)}");
            Console.WriteLine($"{convertedNum1} - {convertedNum2} = {calc.Subtract(convertedNum1, convertedNum2)}");
            Console.WriteLine($"{convertedNum1} * {convertedNum2} = {calc.Multiply(convertedNum1, convertedNum2)}");
            Console.WriteLine();

            // for the other 3 methods use Parse to get numerical inputs
            Console.WriteLine("*** Getting numerical values with int.Parse ***");
            Console.WriteLine("Please, input the first number: ");
            int parsedNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, input the second number: ");
            int parsedNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{parsedNum1} / {parsedNum2} = {calc.Divide(parsedNum1, parsedNum2)}");
            Console.WriteLine($"{parsedNum1} % {parsedNum2} = {calc.Remainder(parsedNum1, parsedNum2)}");

            // getting numerical input to calculate circle area
            Console.WriteLine("Please, input radius of the circumference: ");
            int circleRadius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Area of the circle is: {calc.CircleArea(circleRadius)}");
        }
    }
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            return (double)num1 / num2;
        }

        public int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }

        public double CircleArea(double radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
