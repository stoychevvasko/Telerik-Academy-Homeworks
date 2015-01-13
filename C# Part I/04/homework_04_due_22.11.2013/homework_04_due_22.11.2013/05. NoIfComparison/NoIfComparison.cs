using System;
using System.Threading;
using System.Globalization;
using System.Text;

class NoIfComparison
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "NoIfComparison.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will print out the greater of two numbers");
        Console.WriteLine("without the use of If statements in the source code.");
        Console.WriteLine();
        Console.WriteLine("Use dot (.) as your decimal mark.");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the first number:");
        decimal num1;
        string keyboardInput = Console.ReadLine();

        while (!decimal.TryParse(keyboardInput, out num1))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to numeric value. Please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the second number:");
        decimal num2;
        keyboardInput = Console.ReadLine();

        while ((!decimal.TryParse(keyboardInput, out num2)) || (num1 == num2))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to numeric value or numbers are equal. Please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The greater of the two numbers is {0}.", (num1 > num2) ? num1 : num2);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}