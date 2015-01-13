using System;
using System.Threading;
using System.Globalization;

class PointInCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PointInCircle.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will determine if a point with coordinates (x, y)");
        Console.WriteLine("is within a circle K(0, 5).");
        Console.WriteLine();
        Console.WriteLine("Use dot (.) as your decimal mark when entering values.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please enter the x coordinate of the point:");

        decimal x;
        string keyboardInput = Console.ReadLine();
        
        while (!decimal.TryParse(keyboardInput, out x))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid numeric value for x, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the y coordinate of the point:");
        decimal y;
        keyboardInput = Console.ReadLine();

        while (!decimal.TryParse(keyboardInput, out y))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid numeric value for y, please try again:");
            keyboardInput = Console.ReadLine();
        }

        if (x * x + y * y <= 5 * 5)
        {
            Console.WriteLine();
            Console.WriteLine("The point you entered is within the circle.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The point you entered is not within the circle.");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}