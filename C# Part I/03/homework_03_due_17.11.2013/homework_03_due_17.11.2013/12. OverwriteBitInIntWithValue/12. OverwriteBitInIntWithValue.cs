using System;
using System.Threading;
using System.Globalization;

class OverwriteBitInIntWithValue
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "OverwriteBitInIntWithValue.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will overwrite the bit at location p within an integer n.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please enter an integer:");

        int n;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out n))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid integer value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the bit position p. The value must be from 0 to 31:");
        int p;
        keyboardInput = Console.ReadLine();
        while (!int.TryParse(keyboardInput, out p) || (p < 0) || (p > 31))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid position value or position is out of range.");
            Console.WriteLine("Please try again with a number from 0 to 31:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the value v to be overwritten. The value must be 0 or 1:");
        int v;
        keyboardInput = Console.ReadLine();
        while (!int.TryParse(keyboardInput, out v) || ((v != 0) && (v != 1)))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid bit value. Please try again with 0 or 1 only:");
            keyboardInput = Console.ReadLine();
        }

        int mask = 1 << p;
        int finalResult;

        if (v == 0)
        {
            finalResult = n & (~mask); 
        }
        else
        {
            finalResult = n | mask;
        }

        Console.WriteLine();        //printing results
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Old integer is represented as {0} in binary.", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.Write("                            ");
        
        for (int i = 32 - p; i >= 0; --i)
        {
            Console.Write(" ");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine('\u25BC');
        Console.ForegroundColor = ConsoleColor.Red;
        
        Console.Write("Value for overwrite:        ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        for (int i = 32 - p; i >= 0; --i)
        {
            Console.Write(" ");
        }
        
        Console.WriteLine(v);
        Console.Write("                            ");
        
        for (int i = 32 - p; i >= 0; --i)
        {
            Console.Write(" ");
        }
        
        Console.WriteLine('\u25BC');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("New integer is represented as {0} in binary.", Convert.ToString(finalResult, 2).PadLeft(32, '0'));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The final result is {0}.", finalResult);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}