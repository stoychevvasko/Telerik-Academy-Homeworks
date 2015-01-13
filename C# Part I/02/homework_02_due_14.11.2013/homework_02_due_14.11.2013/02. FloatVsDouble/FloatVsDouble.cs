using System;
using System.Threading;
using System.Globalization;

class FloatVsDouble
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "FloatVsDouble";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        double variable1 = 34.567839023d;
        float variable2 = 12.345f;
        double variable3 = 8923.12345857d;
        float variable4 = 3456.091f;
        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}", variable1, variable2, variable3, variable4);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}