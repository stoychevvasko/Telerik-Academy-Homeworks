using System;
using System.Threading;
using System.Globalization;


class DivisibleBy7And5IntCheck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DivisibleBy7And5IntCheck.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("Please enter an integer to check if it divisible by 5 and 7:");
        int num;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        if ((num % 5 == 0) && (num % 7 == 0))
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The number {0} is divisible by 5 and 7.", num);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The number {0} is not divisible by 5 and 7.", num);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}