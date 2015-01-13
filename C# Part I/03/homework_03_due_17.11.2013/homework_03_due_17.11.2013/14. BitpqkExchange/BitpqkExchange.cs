using System;
using System.Threading;
using System.Globalization;

class BitpqkExchange
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
        return result;  //This method is used for swapping the bits at bitPositionOne and bitPositionTwo 
    }                   //of any sourceInteger. I have called it further down.
    
    
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BitpqkExchange.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will exchange bits {p, p+1, ..., p+k-1}");
        Console.WriteLine();
        Console.WriteLine("                          with bits {q, q+1, ..., q+k-1}.");
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
        Console.WriteLine("Please enter the bit position q > p. The value must be from 0 to 31:");
        int q;
        keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out q) || (q < 0) || (q > 31) || (q <= p))
        {
            Console.WriteLine();
            Console.WriteLine("You have entered an invalid position value or position is out of range.");
            Console.WriteLine("Please try again with a number from 0 to 31:");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the position shift number k:");
        int k;
        keyboardInput = Console.ReadLine();
        
        while (!int.TryParse(keyboardInput, out k)||(p+k-1<0)||(p+k-1>31)||(q+k-1<0)||(q+k-1>31)||(p+k-1>=q))
        {                                       
                                                //Checking whether the resulting positions after the shift 
                                                //are within the [0, 31] range of allowed bit positions
            
            Console.WriteLine();                
            Console.WriteLine("You have entered an invalid position shift value");
            Console.WriteLine("or shift position goes out of range.");
            Console.WriteLine("Please try again with a number from 0 to 31:");
            keyboardInput = Console.ReadLine();
        }

        int resultNum = (int)num;
        for (int count = 0; count <= k - 1; count++)
        {
            resultNum = SwapBits(resultNum, p + count, q + count);
        }           
                    //Calling SwapBits repeatedly to perform the bit swaps
                    //for every pair of bit positions


        Console.WriteLine();            //printing results
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine();
        Console.Write("Old integer is represented as {0} in binary.", Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.WriteLine();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("                              ");

        for (int count = 0; count < 31 - (q + k - 1); count++)
        {
            Console.Write(" ");
        }

        for (int count = 31 - (q + k); count < 31 - q; count++)
        {
            Console.Write('\u25B2');
        }
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        for (int count = 31 - q + 1; count < 31 - (p + k - 1); count++)
        {
            Console.Write(" ");
        }

        for (int count = 31 - (p + k); count < 31 - p; count++)
        {
            Console.Write('\u25B2');
        }

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("                              ");

        for (int count = 0; count < 31 - (q + k - 1); count++)
        {
            Console.Write(" ");
        }

        for (int count = 31 - (q + k); count < 31 - q; count++)
        {
            Console.Write('\u25BC');
        }

        Console.ForegroundColor = ConsoleColor.Green;
        for (int count = 31 - q + 1; count < 31 - (p + k - 1); count++)
        {
            Console.Write(" ");
        }

        for (int count = 31 - (p + k); count < 31 - p; count++)
        {
            Console.Write('\u25BC');
        }

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