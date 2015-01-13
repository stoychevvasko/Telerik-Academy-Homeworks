using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that reads a year from the console 
//     and checks whether it is a leap. Use DateTime.

class LeapYear
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "LeapYear";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("Please enter a year here: ");
        string input = Console.ReadLine();
        int year = int.Parse(input);
        
        Console.WriteLine();
        Console.WriteLine("Is this year a leap year? {0}", DateTime.IsLeapYear(year));

        Console.WriteLine();
        Console.ReadKey();
    }
}


