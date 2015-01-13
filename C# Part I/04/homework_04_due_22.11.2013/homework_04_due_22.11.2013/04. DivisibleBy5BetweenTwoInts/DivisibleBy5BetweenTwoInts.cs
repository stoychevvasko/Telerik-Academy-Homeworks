using System;
using System.Threading;
using System.Globalization;
using System.Text;

class DivisibleBy5BetweenTwoInts
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DivisibleBy5BetweenTwoInts.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will count p as the number of integers divisible by 5");
        Console.WriteLine("between positive integers a and b as provided by the user.");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Please enter integer a:");
        uint a = 0;
        string keyboardInput = Console.ReadLine();

        while (!uint.TryParse(keyboardInput, out a) || a == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to a numeric value or value is non-positive, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter integer b:");
        uint b = 0;
        keyboardInput = Console.ReadLine();

        while (!uint.TryParse(keyboardInput, out b) || b == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to a numeric value or value is non-positive, please try again:");
            keyboardInput = Console.ReadLine();
        }

        if (b < a)      // For this exercise I make sure the interval is [a, b], not [b, a]
        {               
            uint c = b;
            b = a;
            a = c;
        }

        uint p = 0;
        for (int i = (int)a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                ++p;
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The number of integers in the interval [{0}, {1}] divisible by 5 is", a, b);
        Console.WriteLine();
        Console.WriteLine("                             p = {0}", p);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}