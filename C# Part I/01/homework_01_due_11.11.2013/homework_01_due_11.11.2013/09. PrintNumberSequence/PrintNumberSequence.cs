using System;
using System.Threading;
using System.Globalization;

class PrintNumberSequence
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrintNumberSequence.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine();

        for (int num = 2; num < 11; num++)
        {
            Console.Write(" {0}  ", num);
            num++;
            Console.Write("{0}  ", (num * -1));
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

