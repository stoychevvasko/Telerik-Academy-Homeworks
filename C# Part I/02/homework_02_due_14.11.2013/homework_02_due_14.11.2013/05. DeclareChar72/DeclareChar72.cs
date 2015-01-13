using System;
using System.Threading;
using System.Globalization;

class DeclareChar72
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DeclareChar72";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        char character = '\u0048'; //48 is the hex equivalent of 72
        Console.WriteLine(character);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}