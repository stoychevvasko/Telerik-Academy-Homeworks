using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program to convert from any numeral system 
//     of given base s to any other numeral system of base 
//     d (2 ≤ s, d ≤  16).

class BaseSToBaseDConversion
{
    // this string comprises a total of 64 unique digits for conversion purposes
    public const string allDigits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#$";

    static public ulong SimplePow(ulong num, ulong pow)
    {
        ulong result = 1;

        for (ulong i = 0; i < pow; i++)
        {
            result *= num;
        }

        return result;
    }

    static public ulong ConvertSToDec(string sourceNum, ulong numeralSys)
    {               
        ulong result = 0;
        ulong pow = 0;

        for (int i = sourceNum.Length - 1; i >= 0; i--)
        {
            result += (ulong)allDigits.IndexOf(sourceNum[i]) * SimplePow(numeralSys, pow);
            pow++;
        }

        return result;
    }

    static public string ConvertDecToD(ulong sourceNum, ulong numeralSys)
    {
        string resultString = "";

        while (sourceNum != 0)
        {
            resultString = allDigits[(int)sourceNum % (int)numeralSys] + resultString;
            sourceNum /= numeralSys;
        }

        return resultString;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BaseSToBaseDConversion";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("<!> Note that capital letters (A, B, C...) are considered distinct from small ");
        Console.WriteLine("letters (a, b, c...) in my sequence of digits. Please use capitals when entering");
        Console.WriteLine("hexadecimal numbers <!>");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("What is the source numeral system? s = ");
        ulong s = ulong.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("What is the source number in numeral system ({0})? ", s);
        string sourceNum = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is the target numeral system? d = ");
        ulong d = ulong.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("The number in numeral system ({0}) is {1}", d, ConvertDecToD(ConvertSToDec(sourceNum, s), d));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}