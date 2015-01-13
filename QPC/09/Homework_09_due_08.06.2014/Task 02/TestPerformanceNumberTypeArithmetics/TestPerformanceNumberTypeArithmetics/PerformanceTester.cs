// <copyright file="PerformanceTester.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

/*
Write a program to compare the performance of add, subtract, increment, multiply, divide for 
int, long, float, double and decimal values.
 */

namespace TestPerformanceNumberTypeArithmetics
{
    using System;

    /// <summary>Evaluates the performance of various number types and operations.</summary>
    public static class PerformanceTester
    {
        /// <summary>Main program sequence</summary>
        public static void Main()
        {
            AdditionTester.DoAllTests();
            Console.WriteLine();
            SubtractionTester.DoAllTests();
            Console.WriteLine();
            IncrementTester.DoAllTests();
            Console.WriteLine();
            MultiplicationTester.DoAllTests();
            Console.WriteLine();
            DivisionTester.DoAllTests();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
