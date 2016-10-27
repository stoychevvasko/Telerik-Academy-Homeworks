using System;
using System.Threading;
using System.Globalization;
using System.Text;

class Fibonacci100
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Fibonacci100.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application prints the first 100 members of the Fibonacci sequence.");
        Console.WriteLine();
        Console.WriteLine();

        
        decimal[] number = new decimal[100];
        number[0] = 1;
        number[1] = 1;

        for (int i = 2; i <= 99; i++)
        {
            number[i] = number[i - 1] + number[i - 2];
        }

        for (int i = 0; i <= 99; i++)
        {
            Console.WriteLine("Fibonacci member no. {0, 3}.     {1, 22}", i+1, number[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}