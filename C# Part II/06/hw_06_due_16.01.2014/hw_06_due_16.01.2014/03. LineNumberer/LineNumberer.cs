using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

class LineNumberer
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 40;
        Console.Title = "LineNumberer";
        
        Console.Clear();

        string sourcePath = @"../../source.txt";
        string targetPath = @"../../target.txt";
        
        StreamReader read = new StreamReader(sourcePath);
        StreamWriter write = new StreamWriter(targetPath);
        int i = 1;

        while (!read.EndOfStream)
        {
            string line = read.ReadLine();
            write.WriteLine(i + ". " + line);
            i++;
        }

        read.Close();
        write.Close();

        Console.WriteLine("Done.");
        Console.ReadKey();
    }
}