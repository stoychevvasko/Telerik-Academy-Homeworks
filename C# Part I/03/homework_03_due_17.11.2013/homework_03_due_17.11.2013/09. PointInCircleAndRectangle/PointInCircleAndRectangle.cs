using System;
using System.Threading;
using System.Globalization;

class PointInCircleAndRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PointInCircleAndRectangle.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will determine if a point with coordinates (x, y) is within");
        Console.WriteLine("na circle K((1,1), 3) and a rectangle R(top=1, left=-1, width=6, height=2).");
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

        bool isWithinCircle = (x * x + y * y <= 3 * 3);
        bool isWithinRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
        
        if (isWithinCircle && isWithinRectangle)
        {
            Console.WriteLine();
            Console.WriteLine("The point [{0}, {1}] is within both the circle and rectangle.", x, y);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The point [{0}, {1}] is not within both the circle and rectangle.", x, y);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}