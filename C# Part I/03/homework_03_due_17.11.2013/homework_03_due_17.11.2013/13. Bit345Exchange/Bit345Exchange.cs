using System;
using System.Threading;
using System.Globalization;

class Bit345Exchange
{
    static public int SwapBits(int sourceInteger, int bitPositionOne, int bitPositionTwo)
    {
        int bitOne = ((sourceInteger >> bitPositionOne) % 2) == 1 ? 1 : 0;
        int bitTwo = ((sourceInteger >> bitPositionTwo) % 2) == 1 ? 1 : 0;
        int mask = (1 << bitPositionOne);
        int result = sourceInteger;

        if (bitTwo == 0)
        {
            result = (result & (~mask));
        }
        else
        {
            result = (result | mask);
        }
               
        mask = (1 << bitPositionTwo);

        if (bitOne == 0)
        {
           result = (result & (~mask));
        }
        else
        {
            result = (result | mask);
        }
        return result; //This method is used for swapping the bits at bitPositionOne and bitPositionTwo 
    }                   //of any sourceInteger. I have called it further down.
    
    
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Bit345Exchange.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will exchange bit 3 with bit 24, bit 4 with bit 25 ");
        Console.WriteLine("and bit 5 with bit 26.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please enter an integer:");

        uint num;
        string keyboardInput = Console.ReadLine();
        while (!uint.TryParse(keyboardInput, out num))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid integer value, please try again:");
            keyboardInput = Console.ReadLine();
        }

        int resultNum = (int)num;

        resultNum = SwapBits((int)num, 3, 24);  //This is where the swapping takes place
        resultNum = SwapBits(resultNum, 4, 25); //by calling the SwapBits method we defined
        resultNum = SwapBits(resultNum, 5, 26); //previously using the pre-defined bit positions.

        Console.WriteLine();        //printing results
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine();
        Console.Write("Old integer is represented as {0} in binary.", Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("                                   \u25B2\u25B2\u25B2");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("                  \u25B2\u25B2\u25B2");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("                                   \u25BC\u25BC\u25BC");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("                  \u25BC\u25BC\u25BC");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("New integer is represented as {0} in binary.", Convert.ToString((uint)resultNum, 2).PadLeft(32, '0'));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The final result is {0}.", (uint)resultNum);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}