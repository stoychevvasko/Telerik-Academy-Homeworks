using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert hexadecimal numbers to 
//     binary numbers (directly).

class HexToBin
{
    static public ulong ConvertHexToBin(string num)
    {
        string hexDigits = "0123456789ABCDEF";
        string resultString = "";

        for (int i = 0; i < num.Length; i++)
        {
            resultString += Convert.ToString(hexDigits.IndexOf(num[i]), 2);
        }

        ulong result = ulong.Parse(resultString);

        return result;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "HexToBin";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a hexadecimal number:");
        string sourceNum = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("This is the resulting binary number:");
        Console.WriteLine(ConvertHexToBin(sourceNum));
        Console.WriteLine();
        Console.ReadKey();
    }
}