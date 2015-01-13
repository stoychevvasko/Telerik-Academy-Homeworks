using System;
using System.Threading;
using System.Globalization;
using System.Text;

class GCDCalc
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "GCDCalc";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application calculates the Greatest Common Divisor");
        Console.WriteLine("(GCD) of two integers.");
        Console.WriteLine();
        Console.Write("Please enter the first integer num1 = ");

        string keyboardInput = Console.ReadLine();
        int num1;

        while (!int.TryParse(keyboardInput, out num1))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the first integer num1 = ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Please enter the second integer num2 = ");

        keyboardInput = Console.ReadLine();
        int num2;

        while (!int.TryParse(keyboardInput, out num2))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot convert to numeric value!");
            Console.WriteLine();
            Console.Write("Please enter the second integer num2 = ");
            keyboardInput = Console.ReadLine();
        }
        
        if (num1 < 0)
        {
            num1 = (-1) * num1;
        }

        if (num2 < 0)
        {
            num2 = (-1) * num2;
        }

        // making sure GCD is always positive by turning num1 and num2 into positive numbers

        int gCDValue = 1;
        
        if (num1 == num2)
        {
            gCDValue = num1;
        }
        
        while ((num1 != 0) && (num2 != 0) && (num1 != num2))
        {
            while ((num1 != num2) && (num1 != 0) && (num2 != 0))
            {
                while (num1 > num2)
                {
                    num1 = num1 - num2;
                    gCDValue = num1;
                }

                while (num1 < num2)
                {
                    num2 = num2 - num1;
                    gCDValue = num2;
                }
            }
        }
                

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The GCD is {0}", gCDValue);
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}

