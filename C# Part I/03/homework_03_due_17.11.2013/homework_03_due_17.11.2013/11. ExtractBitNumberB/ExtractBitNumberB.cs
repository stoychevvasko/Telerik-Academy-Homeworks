using System;
using System.Threading;
using System.Globalization;

class ExtractBitNumberB
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ExtractBitNumberB.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will extract the bit at location b within an integer.");
        Console.WriteLine();
        Console.WriteLine("Please enter an integer:");

        int num;
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out num))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid integer value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the bit position b. The value must be from 0 to 31:");
        
        int b;
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out b) || (b < 0) || (b > 31))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid position value or position is out of range.");
            Console.WriteLine("Please try again with a number from 0 to 31:");
            keyboardInput = Console.ReadLine();
        }
        
        int value = (((num >> b) % 2) == 1) ? 1 : 0;

        Console.WriteLine();        //printing results
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Bit number {0} from the integer {1} is {2}.", b, num, value);
        Console.WriteLine();
        Console.WriteLine("The integer is represented as {0} in binary.", Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.Write("                            ");
        
        for (int i = 32 - b; i >= 0; --i)
        {
            Console.Write(" ");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine('\u25B2');
        Console.Write("                   ");

        for (int i = 32 - b; i >= 0; --i)
        {
            Console.Write(" ");
        }

        Console.WriteLine("  The bit!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
    }
}