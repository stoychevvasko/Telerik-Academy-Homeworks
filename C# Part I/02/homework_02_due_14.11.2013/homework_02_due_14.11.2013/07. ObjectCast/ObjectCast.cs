using System;
using System.Threading;
using System.Globalization;

class ObjectCast
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ObjectCast";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        string helloString = "Hello";
        string worldString = "World";
        object objectMessage = helloString + ", " + worldString + "!";
        string finalMessage = (string)objectMessage;
        Console.WriteLine(finalMessage);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}