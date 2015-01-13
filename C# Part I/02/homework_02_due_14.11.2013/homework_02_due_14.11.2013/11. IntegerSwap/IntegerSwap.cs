using System;
using System.Threading;
using System.Globalization;

class IntegerSwap
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IntegerSwap";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        int numberOne = 5;
        int numberTwo = 10;

        numberOne = numberOne + numberTwo;
        numberTwo = numberOne - numberTwo;
        numberOne = numberOne - numberTwo;

        Console.WriteLine("Originally numberOne was 5 and numberTwo was 10.");
        Console.WriteLine();
        Console.WriteLine("Now that the swap is complete, numberOne is {0} and numberTwo is {1}.", numberOne, numberTwo);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}