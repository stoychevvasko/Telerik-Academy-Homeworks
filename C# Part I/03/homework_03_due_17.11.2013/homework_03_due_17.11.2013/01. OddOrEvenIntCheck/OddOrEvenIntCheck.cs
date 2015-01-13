using System;
using System.Threading;
using System.Globalization;


class OddOrEvenIntCheck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "OddOrEvenIntCheck.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("Please enter an integer to check if it is odd or even:");
        int num;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        if (num % 2 == 0)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The number {0} is even.", num);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The number {0} is odd.", num);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}