using System;
using System.Diagnostics;

namespace HW._06.Task3.Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long[] testArr = new long[100_000_000];
            Random r = new Random();

            for (int i = 0; i < testArr.Length; i++)
                testArr[i] = r.Next(int.MinValue, int.MaxValue);
            stopwatch.Stop();
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to fill the array");
            Console.WriteLine();

            ReverseBenchmark(testArr);

            CustomReverseBenchmark(testArr);

            CustomReverse2Benchmark(testArr);
        }

        static void ReverseBenchmark(long[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Array.Reverse(array);
            stopwatch.Stop();
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to reverse the array with Array.Reverse");
        }

        static void CustomReverseBenchmark(long[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HW._06.Task3.Program.CustomReverse(array);
            stopwatch.Stop();
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to reverse the array with CustomReverse");
        }

        static void CustomReverse2Benchmark(long[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HW._06.Task3.Program.CustomReverse2(array);
            stopwatch.Stop();
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to reverse the array with CustomReverse2");
        }
    }
}
