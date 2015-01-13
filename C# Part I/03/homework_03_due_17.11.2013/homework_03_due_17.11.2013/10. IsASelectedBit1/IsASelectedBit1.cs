using System;
using System.Threading;
using System.Globalization;

class IsASelectedBit1
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "IsASelectedBit1.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will check if the bit at location p within an integer is 1.");
        Console.WriteLine();
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

        bool bitp;
        if (((num >> p) % 2) == 1)
        {
            bitp = true;
        }
        else
        {
            bitp = false;
        }

        Console.WriteLine();        //printing results
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The value of the boolean variable bitp is {0}.", bitp);

        Console.WriteLine();
        Console.WriteLine("Bit number {0} from the integer {1} is {2}.", p, num, (bitp ? "1" : "0"));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The integer is represented as {0} in binary.", Convert.ToString(num, 2).PadLeft(32, '0'));
        
        Console.Write("                            ");
        for (int i = 32 - p; i >= 0; --i)
        {
            Console.Write(" ");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine('\u25B2');

        Console.Write("                   ");
        for (int i = 32 - p; i >= 0; --i)
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