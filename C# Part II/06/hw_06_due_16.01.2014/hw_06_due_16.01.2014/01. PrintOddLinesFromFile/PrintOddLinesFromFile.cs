using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class PrintOddLinesFromFile
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 80;
        Console.Title = "PrintOddLinesFromFile";
        
        Console.Clear();


        string path = @"../../text_file.txt";

        StreamReader read = new StreamReader(path);
        int i = 1;

        while (!read.EndOfStream)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(read.ReadLine());
            }
            else
            {
                read.ReadLine();
            }
            i++;
        }
                
        Console.WriteLine();
        Console.ReadKey();
    }
}