using System;
using System.Threading;
using System.Globalization;

class BooleanBit3FromInt
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BooleanBit3FromInt.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will display  bit number 3 from an integer.");
        Console.WriteLine();
        Console.WriteLine("The rightmost bit is counted as bit 0.");
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

        bool bit3;
        if (((num >> 3) % 2) == 1)
        {
            bit3 = true;
        }
        else
        {
            bit3 = false;
        }

        Console.WriteLine();        //printing results
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Bit number 3 from the integer {0} is {1}.", num, bit3 ? "1" : "0");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The integer is represented as {0} in binary.", Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                                          \u25B2");
        Console.WriteLine("                                                Here it is!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
    }
}