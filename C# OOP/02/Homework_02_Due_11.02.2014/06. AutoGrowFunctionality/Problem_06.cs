/*

<Problem 06>

Implement auto-grow functionality: when the
internal array is full, create a new array of double
size and move all elements to it.

*/

// already implemented auto-grow functionality in GenericList.cs
// from <Problem 05> - starts from line 82 as part of the 
// GenericList<T> Add() method

namespace _06.AutoGrowFunctionality
{
    using System;
    using System.Globalization;
    using System.Threading;
    using _05.GenericClass;

    // added reference to <Problem 05>

    class Problem_06
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "06. AutoGrowFunctionality";
            Console.SetWindowSize(45, 15);
            Console.BufferWidth = Console.WindowWidth = 45;
            Console.BufferHeight = Console.WindowHeight = 15;

            GenericList<string> testList = new GenericList<string>();

            for (int i = 0; i < 16; i++)
            {
                testList.Add((i + 1).ToString());
            }

            Console.WriteLine(testList.ToString());
            Console.WriteLine("testList.Capacity: " + testList.Capacity);

            Console.WriteLine();
            Console.WriteLine("We have now added another element. ");
            Console.WriteLine("Capacity expands automatically.");
            Console.WriteLine();

            testList.Add("17");
            Console.WriteLine(testList.ToString());
            Console.WriteLine("testList.Capacity: " + testList.Capacity);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
