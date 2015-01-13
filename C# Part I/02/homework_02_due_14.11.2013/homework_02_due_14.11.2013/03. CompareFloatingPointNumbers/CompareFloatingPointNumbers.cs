using System;
using System.Threading;
using System.Globalization;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CompareFloatingPointNumbers";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will compare two numbers represented as doubles in C#.");
        Console.WriteLine("Use dot (.) as your decimal mark.");
        Console.WriteLine();
        Console.WriteLine("Please enter the first number:");
        
        string numberOne = Console.ReadLine();
        double number1;

        while (!Double.TryParse(numberOne, out number1))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            numberOne = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the second number:");
        string numberTwo = Console.ReadLine();
        double number2;

        while (!Double.TryParse(numberTwo, out number2))
        {
            Console.WriteLine();
            Console.WriteLine("This string cannot be converted to a numeric value, please try again:");
            numberTwo = Console.ReadLine();
        }

        if (Math.Abs(number2 - number1) <= 0.000001)
        {
            Console.WriteLine();
            Console.WriteLine("The numbers are equal with precision of 0.0000001.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The numbers are not equal.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}
