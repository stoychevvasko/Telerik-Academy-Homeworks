using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections.Generic;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

class NameSorterFile
{
    public static void GenerateNames(int number, string filePathToAppend)
    {
        string[] names = {
                             "Georgi", "Aleksandar", "Martin", "Ivan", "Dimitar", "Nikolay", "Daniel", "Nikola", "Victor",
                            
                             "Viktoria", "Maria", "Aleksandra", "Gabriela", "Raya", "Yoana", "Daria", "Simona", "Iliyana"
                         };

        Random rand = new Random();

        StreamWriter write = new StreamWriter(@filePathToAppend);

        List<string> unsortedNames = new List<string>();

        for (int i = 0; i < number; i++)
        {
            unsortedNames.Add(names[rand.Next(names.Length)]);
        }

        foreach (string item in unsortedNames)
        {
            write.Write(item + ' ');
        }

        write.Close();

    }

    public static List<string> ReadNames(string filePath)
    {
        List<string> result = new List<string>();

        StreamReader read = new StreamReader(@filePath);
        string allNames = read.ReadToEnd();
        read.Close();

        string[] names = allNames.Split(' ');

        foreach (string item in names)
        {
            result.Add(item);
        }

        return result;

    }

    public static void SaveListOfStrings(List<string> listOfStr, string filePath)
    {
        StreamWriter write = new StreamWriter(@filePath);

        foreach (string item in listOfStr)
        {
            write.Write(item + ' ');
        }

        write.Close();
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 5;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.Title = "NameSorterFile";
        
        Console.Clear();

        //GenerateNames(100, "../../unsorted_names.txt");
        //Console.WriteLine("Names added to file.");

        List<string> tempNames = ReadNames("../../unsorted_names.txt");
        
        tempNames.Sort();

        SaveListOfStrings(tempNames, "../../sorted_names.txt");

        Console.WriteLine("Done.");



        Console.WriteLine();
        Console.ReadKey();
    }
}


