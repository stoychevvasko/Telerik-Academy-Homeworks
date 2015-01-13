using System;
using System.Threading;
using System.Globalization;


class HelloCSharp
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "HelloCSharp.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        

        Console.WriteLine("Hello C#!");
    }
}

