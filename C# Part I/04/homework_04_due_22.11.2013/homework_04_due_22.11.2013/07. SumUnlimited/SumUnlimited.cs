using System;
using System.Threading;
using System.Globalization;
using System.Text;

class SumUnlimited
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SumUnlimited.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will calculate the sum of n numbers.");
        Console.WriteLine();
        Console.WriteLine("Use dot (.) as your decimal mark.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("How many numbers would you like to sum? n = ");
        string keyboardInput = Console.ReadLine();
        int n;

        while (!int.TryParse(keyboardInput, out n) || (n < 2))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value or n < 2. Try again:");
            keyboardInput = Console.ReadLine();
        }

        decimal entryNum, sum = 0;
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.Write("Please enter number{0}:   ", i);
            keyboardInput = Console.ReadLine();

            while (!decimal.TryParse(keyboardInput, out entryNum))
            {
                Console.WriteLine();
                Console.WriteLine("Cannot convert to numeric value. Try again!");
                Console.WriteLine();
                Console.Write("Please enter number{0}:   ", i);
                keyboardInput = Console.ReadLine();
            }
            sum += entryNum;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The sum of the {0} numbers you entered is {1}.", n, sum);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}