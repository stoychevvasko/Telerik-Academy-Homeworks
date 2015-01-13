/*

<Problem 20*>

By using delegates develop an universal static
method to calculate the sum of infinite convergent 
series with given precision depending on a function 
of its term. By using proper functions for the term 
calculate with a 2-digit precision the sum of the 
infinite series:

	1 + 1/2 + 1/4 + 1/8 + 1/16 + …
    1 + 1/2! + 1/3! + 1/4! + 1/5! + …
	1 + 1/2 - 1/4 + 1/8 - 1/16 + … 

*/

namespace _20.InfiniteConvergentSeriesSum
{
    using System;

    class InfiniteConvergentSeriesSum
    {
        static void Main()
        {
            Console.Title = "20.InfiniteConvergentSeriesSum";
            Console.SetWindowSize(40, 15);
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 15;


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
