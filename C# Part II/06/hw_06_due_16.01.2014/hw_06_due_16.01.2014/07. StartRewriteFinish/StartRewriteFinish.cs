using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections.Generic;


//Write a program that replaces all occurrences of the substring "start" with the substring 
//"finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

class StartRewriteFinish
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.Title = "StartRewriteFinish";
        
        Console.Clear();

        string sourcePath = "../../war_and_peace.txt";
        StreamReader read = new StreamReader(@sourcePath);

        string text = read.ReadToEnd();
        read.Close();

        text = text.Replace("start", "finish");

        string targetPath = "../../war_and_peace_altered.txt";
        StreamWriter write = new StreamWriter(@targetPath);

        for (int i = 0; i < text.Length; i++)
        {
            write.Write(text[i]);
        }

        write.WriteLine();
        write.Close();

        Console.WriteLine("Done.");

        Console.WriteLine();
        Console.ReadKey();
    }
}


