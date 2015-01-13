using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines 
//that are the same and the number of lines that are different. Assume the files have equal number of lines.


class TextComparer
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 10;
        Console.BufferWidth = Console.WindowWidth = 40;
        Console.Title = "TextComparer";
        
        Console.Clear();

        string path1 = @"../../text_file_1.txt";
        string path2 = @"../../text_file_2.txt";

        StreamReader read1 = new StreamReader(path1);
        StreamReader read2 = new StreamReader(path2);

        int numberOfSameLines = 0;
        int numberOfDifferentLines = 0;

        while (!read1.EndOfStream)
        {
            string string1 = read1.ReadLine();
            string string2 = read2.ReadLine();

            if (string1.CompareTo(string2) == 0)
            {
                numberOfSameLines++;
            }
            else
            {
                numberOfDifferentLines++;
            }
        }

        Console.WriteLine("The number of same lines is {0}.", numberOfSameLines);
        Console.WriteLine();
        Console.WriteLine("The number of different lines is {0}.", numberOfDifferentLines);
        Console.WriteLine();
        Console.ReadKey();
    }
}