using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert binary numbers to 
//     hexadecimal numbers (directly).


class BinToHex
{
    static public string ConvertBinToHex(ulong num)
    {
        string hexDigits = "0123456789ABCDEF";
        string resultString = "";

        string sourceNum = num.ToString();

        while (sourceNum.Length % 4 != 0)
        {
            sourceNum = sourceNum.Insert(0, "0");
        }

        while (sourceNum.Length != 0)
        {
            string halfByteStr = sourceNum.Substring(0, 4);
            sourceNum = sourceNum.Remove(0, 4);

            int halfByte = Convert.ToInt32(halfByteStr, 2);
            resultString += hexDigits[halfByte];
        }

        return resultString;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BinToHex";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a binary number:");
        string input = Console.ReadLine();
        ulong sourceNum = ulong.Parse(input);

        Console.WriteLine();
        Console.WriteLine("This is the resulting hexadecimal number:");
        Console.WriteLine(ConvertBinToHex(sourceNum));
        Console.WriteLine();
        Console.ReadKey();
    }
}