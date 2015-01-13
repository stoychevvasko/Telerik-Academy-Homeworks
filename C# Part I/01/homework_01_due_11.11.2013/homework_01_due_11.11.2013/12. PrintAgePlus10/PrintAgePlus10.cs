using System;
using System.Threading;
using System.Globalization;

class PrintAgePlus10
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrintAgePlus10.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        

        Console.WriteLine("What is your current age? (0-127)");

        sbyte currentAgeNum;
        string keyboardInput = Console.ReadLine();

        while (!sbyte.TryParse(keyboardInput, out currentAgeNum) || (currentAgeNum < 0))
        {
            Console.WriteLine();
            Console.WriteLine("You have enter an invalid age. Please enter it again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This means that in 10 years you will be {0} years old.", (currentAgeNum + 10));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

