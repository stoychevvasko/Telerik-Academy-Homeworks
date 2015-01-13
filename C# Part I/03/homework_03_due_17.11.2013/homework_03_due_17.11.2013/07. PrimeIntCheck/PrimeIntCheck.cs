using System;
using System.Threading;
using System.Globalization;

class PrimeIntCheck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrimeIntCheck.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will check if an integer from 1 to 100 is prime.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please enter your integer:");
        
        string keyboardInput = Console.ReadLine();
        int num;
        while (!int.TryParse(keyboardInput, out num))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value or the number is out of range.");
            Console.WriteLine("Please enter your integer again:");
            keyboardInput = Console.ReadLine();
        }

        bool isPrime = true;

        for (int i = (num - 1); i > 1; --i)
        {
            if (num % i == 0)
            {
                isPrime = false;
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The number {0} is a {1} number.", num, isPrime ? "prime" : "non-prime");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}