using System;
using System.Threading;
using System.Globalization;
using System.Text;

class Read3IntPrintSum
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Read3IntPrintSum.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will read three integers and sum them.");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the first integer:");

        int num1;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num1))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the second integer:");
        int num2;
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num2))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the third integer:");
        int num3;
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num3))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The sum of {0}, {1} and {2} is {3}.", num1, num2, num3, (num1 + num2 +num3));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}