using System;
using System.Threading;
using System.Globalization;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrintASCIITable";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("#######################################################");
        Console.WriteLine();
        Console.WriteLine("               ASCII TABLE OF CHARACTERS");
        Console.WriteLine();
        Console.WriteLine("#######################################################");
        Console.WriteLine();

        char symbol = '\u0000';
        
        for (byte count = 0; count <128; count++)
        {
            Console.Write("          dec  {0,-3}   |   hex  {1,-2}   |       ", count, count.ToString("X"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(symbol);
            Console.ForegroundColor = ConsoleColor.Red;
            symbol++;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Scroll to the top of the console to see the whole ASCII table.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}