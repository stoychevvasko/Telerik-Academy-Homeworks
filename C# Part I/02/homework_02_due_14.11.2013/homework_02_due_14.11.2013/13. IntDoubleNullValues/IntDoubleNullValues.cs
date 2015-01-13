using System;
using System.Threading;
using System.Globalization;

class IntDoubleNullValues
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IntDoubleNullValues";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        int integerVar;
        double doubleVar;

        //integerVar = null;          * this gives "Cannot convert null to 'int' because it is a non-nullable value type" kind of error *
        //doubleVar = null;           * this gives "Cannot convert null to 'double' because it is a non-nullable value type" kind of error *

        int? integerVar2 = null;
        double? doubleVar2 = null;

        Console.WriteLine("\nHere -> {0} <- is a nullable integer...", integerVar2);
        Console.WriteLine();
        Console.WriteLine("and this -> {0} <- is what a nullable double looks like.", doubleVar2);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}