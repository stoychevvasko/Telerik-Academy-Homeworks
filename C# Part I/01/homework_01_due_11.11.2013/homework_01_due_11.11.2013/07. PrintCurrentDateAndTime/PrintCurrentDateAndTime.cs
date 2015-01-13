using System;
using System.Threading;
using System.Globalization;

class PrintCurrentDateAndTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrintCurrentDateAndTime.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        DateTime currentDateTime = DateTime.Now;
        string formatDate = "dd-MM-yyy";
        string formatTime = "HH:mm";
        Console.WriteLine("The current date is {0}.", currentDateTime.ToString(formatDate));
        Console.WriteLine();
        Console.WriteLine("The current time is {0}.", currentDateTime.ToString(formatTime));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

