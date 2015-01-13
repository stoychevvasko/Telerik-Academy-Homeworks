using System;
using System.Threading;
using System.Globalization;

class QuotedStrings
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "QuotedStrings";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        string unquotedString = "The \"use\" of quotations causes difficulties.";
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(unquotedString);
        Console.WriteLine();
        Console.WriteLine(quotedString);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}