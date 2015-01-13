// <copyright file="IncrementTester.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

/*
Write a program to compare the performance of add, subtract, increment, multiply, divide for 
int, long, float, double and decimal values.
 */

namespace TestPerformanceNumberTypeArithmetics
{
    using System;
    using System.Diagnostics;

    /// <summary>Tests the speed of increment applied to various numeric types.</summary>
    public static class IncrementTester
    {
        /// <summary>Perform all available tests in sequence.</summary>
        public static void DoAllTests()
        {
            //// the first load of the Stopwatch object takes more time and interferes with first test, that's why
            //// we do a "purge" here
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            IncrementTester.IncrementIntegersTest();
            IncrementTester.IncrementLongTest();
            IncrementTester.IncrementFloatTest();
            IncrementTester.IncrementDoubleTest();
            IncrementTester.IncrementDecimalTest();
        }

        /// <summary>Tests integer increment performance.</summary>
        public static void IncrementIntegersTest()
        {
            int[] integers = new int[1024];
            integers[0] = 1;
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                integers[i] += integers[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of integers", stopwatch.Elapsed);
        }

        /// <summary>Tests long increment performance.</summary>
        public static void IncrementLongTest()
        {
            long[] longs = new long[1024];
            longs[0] = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                longs[i] += longs[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of longs", stopwatch.Elapsed);
        }

        /// <summary>Tests float increment performance.</summary>
        public static void IncrementFloatTest()
        {
            float[] floats = new float[1024];
            floats[0] = 1.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                floats[i] += floats[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of floats", stopwatch.Elapsed);
        }

        /// <summary>Tests double increment performance.</summary>
        public static void IncrementDoubleTest()
        {
            double[] doubles = new double[1024];
            doubles[0] = 1.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                doubles[i] += doubles[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of doubles", stopwatch.Elapsed);
        }

        /// <summary>Tests decimal increment performance.</summary>
        public static void IncrementDecimalTest()
        {
            decimal[] decimals = new decimal[1024];
            decimals[0] = 1.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                decimals[i] += decimals[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of decimals", stopwatch.Elapsed);
        }
    }
}
