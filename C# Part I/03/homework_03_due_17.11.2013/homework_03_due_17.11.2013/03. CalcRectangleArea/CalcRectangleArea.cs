using System;
using System.Threading;
using System.Globalization;

class CalcRectangleArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CalcRectangleArea.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the surface area of a rectangle.");
        Console.WriteLine("Use dot (.) as your decimal separator when entering numeric values.");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the width of the rectangle:");
        decimal width = 0;
        string keyboardInput = Console.ReadLine();
        
        while ((!decimal.TryParse(keyboardInput, out width)) || (width < 0))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered invalid width, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the height of the rectangle:");
        keyboardInput = Console.ReadLine();
        decimal height = 0;

        while ((!decimal.TryParse(keyboardInput, out height)) || (height < 0))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered invalid height, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The surface area of your rectangle is {0}.", width * height);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}