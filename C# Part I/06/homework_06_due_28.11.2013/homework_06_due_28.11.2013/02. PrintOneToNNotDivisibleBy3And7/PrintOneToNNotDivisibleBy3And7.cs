using System;
using System.Threading;
using System.Globalization;
using System.Text;

class PrintOneToNNotDivisibleBy3And7
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrintOneToNNotDivisibleBy3And7";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will print all numbers from 1 to N");
        Console.WriteLine("that are not divisible by 3 and 7 simultaneously.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the maximum number N = ");

        int N;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out N))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the maximum number N = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int i = 1; i <= N; i++)
        {
            if ((i % 3 != 0) || (i % 7 != 0))
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}

