using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert decimal numbers to their 
//     binary representation.

class DecToBin
{
    static public ulong ConvertDecToBin(ulong num)
    {
        ulong result = 0;
        string resultString = "";

        while (num != 0)
        {
            resultString = (num % 2) + resultString;
            num /= 2;
        }

        result = ulong.Parse(resultString);
        return result;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DecToBin";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a decimal number:");
        string input = Console.ReadLine();
        ulong sourceNum = ulong.Parse(input);
        
        Console.WriteLine();
        Console.WriteLine("This is the resulting binary number:");
        Console.WriteLine(ConvertDecToBin(sourceNum));
        Console.WriteLine();
        Console.ReadKey();
    }
}