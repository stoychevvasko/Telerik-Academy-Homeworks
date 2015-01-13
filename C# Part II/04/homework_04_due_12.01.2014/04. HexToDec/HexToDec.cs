using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert hexadecimal numbers to 
//     their decimal representation.

class HexToDec
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

    static public ulong ConvertHexToDec(string num)
    {
        string hexDigits = "0123456789ABCDEF";
        
        ulong result = 0;
        ulong pow = 0;

        while (num.Length != 0)
        {
            result += ((ulong)hexDigits.IndexOf(num[num.Length - 1])) * SimplePow(16, pow);
            
            num = num.Remove(num.Length - 1, 1);
            pow++;
        }

        return result;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "HexToDec";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a hexadecimal number:");
        string sourceNum = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine("This is the resulting decimal number:");
        Console.WriteLine(ConvertHexToDec(sourceNum));
        Console.WriteLine();
        Console.ReadKey();
    }
}