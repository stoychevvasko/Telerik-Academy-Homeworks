using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections.Generic;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class OddLinesDelete
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 40;
        Console.Title = "OddLinesDelete";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        StreamReader read = new StreamReader(@"../../text.txt");
        
        bool odd = true;
        List<string> newLines = new List<string>();

        while (!read.EndOfStream)
        {
            string str = read.ReadLine();            
            
            if (!odd)
            {
                newLines.Add(str);
            }

            odd = (!odd);            
        }

        read.Close();

        StreamWriter write = new StreamWriter(@"../../text.txt");

        foreach (string item in newLines)
        {
            write.WriteLine(item);
        }

        write.Close();

        Console.WriteLine("Done.");
        Console.WriteLine();
        Console.ReadKey();
    }
}


