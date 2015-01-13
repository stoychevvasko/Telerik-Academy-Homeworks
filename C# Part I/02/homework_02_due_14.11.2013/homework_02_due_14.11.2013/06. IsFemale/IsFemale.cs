using System;
using System.Threading;
using System.Globalization;

class IsFemale
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IsFemale";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("You are a female - true or false?");
        string isFemaleString = Console.ReadLine();
        bool isFemale;

        while (!bool.TryParse(isFemaleString, out isFemale))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid answer. Type \"true\" or \"false\" only, no quotes.");
            Console.WriteLine();
            Console.WriteLine("Are you a female?");
            isFemaleString = Console.ReadLine();
        }

        if (!isFemale)
        {
            Console.WriteLine();
            Console.WriteLine("You are a male.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("You are a female.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();   
    }
}