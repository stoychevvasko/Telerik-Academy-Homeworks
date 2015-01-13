using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

//Write a program that concatenates two text files into another text file.

class MergeTextFiles
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 40;
        Console.Title = "MergeTextFiles";
        
        Console.Clear();

        string source1Path = "../../source_text_1.txt";

        StreamReader read1 = new StreamReader(source1Path);
        string string1 = read1.ReadToEnd();
        read1.Close();
        
        string source2Path = "../../source_text_2.txt";
        StreamReader read2 = new StreamReader(source2Path);
        string string2 = read2.ReadToEnd();
        read2.Close();

        string finalString = string1 + string2;

        string targetPath = "../../target_text.txt";

        StreamWriter write = new StreamWriter(targetPath);
        write.Write(finalString);
        write.Close();

        Console.WriteLine("Done.");
        Console.WriteLine();
        Console.ReadKey();
    }
}