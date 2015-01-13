using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert binary numbers to their 
//     decimal representation.

class BinToDec
{
    static public ulong SimplePow(ulong num, ulong pow)
    {
        ulong result = 1;

        for (ulong i = 0; i < pow; i++)
        {
            result *= num;
        }

        return result;
    }

    static public ulong ConvertBinToDec(ulong num)
    {
        ulong result = 0;
        ulong pow = 0;

        while (num != 0)
        {
            if (num % 10 != 0)
            {
                result += SimplePow(2, pow);
            }
            
            pow++;
            num /= 10;
        }

        return result;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BinToDec";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a binary number:");
        string input = Console.ReadLine();
        ulong sourceNum = ulong.Parse(input);

        Console.WriteLine();
        Console.WriteLine("This is the resulting decimal number:");
        Console.WriteLine(ConvertBinToDec(sourceNum));
        Console.WriteLine();
        Console.ReadKey();
    }
}