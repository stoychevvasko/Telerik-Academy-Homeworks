using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that shows the binary 
//     representation of given 16-bit signed integer number 
//     (the C# type short).

class ShortBinaryRepresentation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "ShortBinaryRepresentation";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter your number here as short type:");
        string input = Console.ReadLine();
        short num = short.Parse(input);

        string binRepresentation = "";

        for (int i = 0; i < 16; i++)
        {
            char bit = ((num & (1 << i)) != 0)?'1':'0';
            binRepresentation = bit + binRepresentation;
        }
        
        Console.WriteLine();
        Console.WriteLine("This is the binary representation of the short number you entered:");
        Console.WriteLine(binRepresentation);

        Console.WriteLine();
        Console.ReadKey();
    }
}