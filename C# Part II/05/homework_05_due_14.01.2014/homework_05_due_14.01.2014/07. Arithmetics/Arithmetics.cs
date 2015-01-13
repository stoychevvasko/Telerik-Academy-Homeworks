using System;
using System.Threading;
using System.Globalization;
using System.Text;

class Arithmetics
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Arithmetics";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();




        Console.WriteLine();
        Console.ReadKey();
    }
}


