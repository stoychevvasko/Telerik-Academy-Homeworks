using System;
using System.Threading;
using System.Globalization;

class Square12345
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Square12345.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        
        Console.WriteLine("The square of 12345 is {0}.",  Math.Pow(12345, 2));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}