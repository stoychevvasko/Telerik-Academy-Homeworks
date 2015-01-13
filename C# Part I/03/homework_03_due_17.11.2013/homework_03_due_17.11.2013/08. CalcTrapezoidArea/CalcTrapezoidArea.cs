using System;
using System.Threading;
using System.Globalization;

class CalcTrapezoidArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CalcTrapezoidArea.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the surface area of a trapezoid.");
        Console.WriteLine();
        Console.WriteLine("Use dot (.) as your decimal separator when entering numeric values.");
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Please enter a as the first base of the trapezoid:");
        decimal a = 0;
        string keyboardInput = Console.ReadLine();
       
        while (!decimal.TryParse(keyboardInput, out a) || (a < 0))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid value for a, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter b as the first base of the trapezoid:");
        decimal b = 0;
        keyboardInput = Console.ReadLine();

        while (!decimal.TryParse(keyboardInput, out b) || (b < 0))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid value for b, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter h as the height of the trapezoid:");
        decimal h = 0;
        keyboardInput = Console.ReadLine();

        while (!decimal.TryParse(keyboardInput, out h) || (h < 0))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid value for h, please try again:");
            keyboardInput = Console.ReadLine();
        }

        decimal surface = ((a + b) * h) / 2;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The surface area of your trapezoid is {0}.", surface);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}