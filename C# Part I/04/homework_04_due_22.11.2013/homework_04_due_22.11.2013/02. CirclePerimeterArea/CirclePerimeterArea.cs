using System;
using System.Threading;
using System.Globalization;
using System.Text;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CirclePerimeterArea.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the perimeter and area surface of a circle");
        Console.WriteLine("defined as K(0, r).");
        Console.WriteLine();
        Console.WriteLine("When entering numeric values, please use dot (.) as your decimal separator.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please enter the value of raius r:");

        decimal radius = 0;
        string keyboardInput = Console.ReadLine();

        while ((!decimal.TryParse(keyboardInput, out radius)) || (radius < 0))
        {
            Console.WriteLine();
            Console.WriteLine("String cannot be converted to numeric value or radius is negative.");
            Console.WriteLine("Please enter the radius value again.");
            keyboardInput = Console.ReadLine();
        }

        const decimal pi = 3.1415926535897932384626433832795M; 
                           //higher precision than Math.PI

        decimal perimeter = 2 * radius * pi;
        decimal area = pi * radius * radius;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The perimeter of your circle is {0}.", perimeter);
        Console.WriteLine();
        Console.WriteLine("The surface area of your circle is {0}.", area);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}