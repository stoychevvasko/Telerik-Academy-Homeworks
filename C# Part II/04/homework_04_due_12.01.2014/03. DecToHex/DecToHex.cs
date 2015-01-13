using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert decimal numbers to their 
//     hexadecimal representation.

class DecToHex
{
    static public string ConvertDecToHex(int num)
    {
        string hexDigits = "0123456789ABCDEF";
        
        string resultString = "";
        
        while (num != 0)
        {
            resultString = hexDigits[num % 16] + resultString;
            num /= 16;
        }

        return resultString;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DecToHex";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a decimal number:");
        string input = Console.ReadLine();
        int sourceNum = int.Parse(input);

        Console.WriteLine();
        Console.WriteLine("This is the resulting hexadecimal number:");
        Console.WriteLine(ConvertDecToHex(sourceNum));
        Console.WriteLine();
        Console.ReadKey();
    }
}