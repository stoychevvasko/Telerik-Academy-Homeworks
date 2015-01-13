// <copyright file="MultiplicationTester.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

/*
Write a program to compare the performance of add, subtract, increment, multiply, divide for 
int, long, float, double and decimal values.
 */

namespace TestPerformanceNumberTypeArithmetics
{
    using System;
    using System.Diagnostics;

    /// <summary>Tests the speed of multiplication applied to various numeric types.</summary>
    public static class MultiplicationTester
    {
        /// <summary>Perform all available tests in sequence.</summary>
        public static void DoAllTests()
        {
            //// the first load of the Stopwatch object takes more time and interferes with first test, that's why
            //// we do a "purge" here
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            MultiplicationTester.MultiplyIntegersTest();
            MultiplicationTester.MultiplyLongTest();
            MultiplicationTester.MultiplyFloatTest();
            MultiplicationTester.MultiplyDoubleTest();
            MultiplicationTester.MultiplyDecimalTest();
        }

        /// <summary>Tests integer multiplication performance.</summary>
        public static void MultiplyIntegersTest()
        {
            int[] integers = new int[1024];
            integers[0] = 1;
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                integers[i] = integers[i - 1] * 2;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of integers", stopwatch.Elapsed);
        }

        /// <summary>Tests long multiplication performance.</summary>
        public static void MultiplyLongTest()
        {
            long[] longs = new long[1024];
            longs[0] = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                longs[i] = longs[i - 1] * 2;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of longs", stopwatch.Elapsed);
        }

        /// <summary>Tests float multiplication performance.</summary>
        public static void MultiplyFloatTest()
        {
            float[] floats = new float[1024];
            floats[0] = 1.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                floats[i] = floats[i - 1] * 2.0F;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of floats", stopwatch.Elapsed);
        }

        /// <summary>Tests double multiplication performance.</summary>
        public static void MultiplyDoubleTest()
        {
            double[] doubles = new double[1024];
            doubles[0] = 1.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                doubles[i] = doubles[i - 1] * 2.0D;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of doubles", stopwatch.Elapsed);
        }

        /// <summary>Tests decimal multiplication performance.</summary>
        public static void MultiplyDecimalTest()
        {
            decimal[] decimals = new decimal[1024];
            decimals[0] = 1.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                decimals[i] = decimals[i - 1] * 0.1M;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of decimals", stopwatch.Elapsed + stopwatch.Elapsed);
        }
    }
}
