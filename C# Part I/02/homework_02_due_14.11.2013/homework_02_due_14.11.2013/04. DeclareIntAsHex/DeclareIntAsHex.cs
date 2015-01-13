using System;
using System.Threading;
using System.Globalization;

class DeclareIntAsHex
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DeclareIntAsHex";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();        


        int num = 0xFE;
        Console.WriteLine("Number {0} in decimal is represented as {0:X} in hex.", num);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}