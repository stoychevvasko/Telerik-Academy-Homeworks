using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Modify the solution of the previous problem to replace only whole words (not substrings).

class Modified7
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.Title = "Modified7";

        Console.Clear();

        string sourcePath = "../../war_and_peace.txt";
        StreamReader read = new StreamReader(@sourcePath);

        string text = read.ReadToEnd();
        read.Close();

        // inserted spaces here

        text = text.Replace(" start ", " finish ");

        //to make them whole words ^

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
