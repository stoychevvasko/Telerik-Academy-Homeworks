using System;
using System.Threading;
using System.Globalization;
using System.Text;

class IntGreaterExchange
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IntGreaterExchange.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will compare two integers provided by the user");
        Console.WriteLine();
        Console.WriteLine("and swap their places if the first one is greater.");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Please enter the first integer: ");
        string keyboardInput = Console.ReadLine();
        int num1;

        while (!int.TryParse(keyboardInput, out num1))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the first integer again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the second integer: ");
        keyboardInput = Console.ReadLine();
        int num2;

        while (!int.TryParse(keyboardInput, out num2))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the second integer again: ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        if (num1 > num2)
        {
            int tempNum = num2;
            num2 = num1;
            num1 = tempNum;
        }

        Console.WriteLine("This is the final result:");
        Console.WriteLine();
        Console.WriteLine("The first number is {0}", num1);
        Console.WriteLine();
        Console.WriteLine("The second number is {0}", num2);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}