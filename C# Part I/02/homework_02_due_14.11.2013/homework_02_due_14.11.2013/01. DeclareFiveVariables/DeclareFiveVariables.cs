using System;
using System.Threading;
using System.Globalization;


class DeclareFiveVariables
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "DeclareFiveVariables";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        ushort variable1 = 52130;
        sbyte variable2 = -115;
        uint variable3 = 4825932;
        byte variable4 = 97;
        short variable5 = -10000;

        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}", variable1, variable2, variable3, variable4, variable5);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}