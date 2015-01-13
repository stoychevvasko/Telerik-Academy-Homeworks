using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that prints to the console which day 
//     of the week is today. Use System.DateTime.

class WeekdayToday
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "WeekdayToday";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Today is {0}.", DateTime.Now.DayOfWeek);
        
        Console.WriteLine();
        Console.ReadKey();
    }
}


