/*

<Problem 08>

Define a class Matrix<T> to hold a matrix of 
numbers (e.g. integers, floats, decimals). 

*/

namespace _08.MatrixOfT
{
    using System;
    using System.Globalization;
    using System.Threading;
    
    class Problem_08
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "08. MatrixOfT";
            Console.SetWindowSize(60, 12);
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 12;            


            // use constructor with dimension parameters

            GenericMatrix<int> testInts = new GenericMatrix<int>(5, 12);
            Console.WriteLine("testInts.Width: {0},    testInts.Height: {1}", testInts.Width, testInts.Height);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // use parameterless constructor

            GenericMatrix<decimal> testDecimals = new GenericMatrix<decimal>();
            Console.WriteLine("testDecimals.Width: {0},    testDecimals.Height: {1}", testDecimals.Width, testDecimals.Height);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();            
        }
    }
}
