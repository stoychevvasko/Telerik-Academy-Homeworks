using System;
using System.Threading;
using System.Globalization;

class Print_1_101_1001
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Print_1_101_1001.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

