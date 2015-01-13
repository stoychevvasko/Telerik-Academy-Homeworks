using System;
using System.Threading;
using System.Globalization;

class ModifiedHelloToPrintMyName
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ModifiedHelloToPrintMyName.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("Chichkovoto Chervenotikvenichkovche");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}