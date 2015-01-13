using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

class RemoveTagsFromXML
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.Title = "RemoveTagsFromXML";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        StreamReader read = new StreamReader(@"../../feature.xml");
        string file = read.ReadToEnd();
        read.Close();
        string newFile = string.Empty;

        StreamWriter write = new StreamWriter(@"../../result.txt");

        bool shouldIWrite = true;

        for (int i = 0; i < file.Length; i++)
        {
            if (file[i].CompareTo('>') == 0)
            {
                shouldIWrite = true;
            }
            else if (file[i].CompareTo('<') == 0)
            {
                shouldIWrite = false;
            }
            else
            {
                if (shouldIWrite)
                {
                    newFile += file[i];
                }
            }
        }
        newFile = newFile.Replace("   ", " ");
        newFile = newFile.Replace("  ", " ");
        newFile = newFile.Replace("\t", "");
        newFile = newFile.Replace("\n", "");
        
        

        write.Write(newFile);
        write.Close();

        Console.WriteLine("Done.");        
        Console.WriteLine();
        Console.ReadKey();
    }
}


