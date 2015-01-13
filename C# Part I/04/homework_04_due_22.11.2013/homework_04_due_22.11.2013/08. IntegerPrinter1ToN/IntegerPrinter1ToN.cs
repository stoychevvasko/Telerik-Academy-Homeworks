using System;
using System.Threading;
using System.Globalization;
using System.Text;

class IntegerPrinter1ToN
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IntegerPrinter1ToN.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will print all integers in the interval [0; n].");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the value n = ");
        string keyboardInput = Console.ReadLine();
        int n;

        while (!int.TryParse(keyboardInput, out n) || (n < 1))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value or n < 1. Try again!");
            Console.WriteLine();
            Console.Write("Please enter the value n = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}