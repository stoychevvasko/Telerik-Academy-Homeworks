using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     You are given a sequence of positive integer values 
//     written into a string, separated by spaces. Write a 
//     function that reads these values from given string 
//     and calculates their sum. Example:
//     string = "43 68 9 23 318" --> result = 461

class SumOfIntsFromString
{
    static public ulong SumFromString(string input)
    {
        ulong sum = 0;

        char[] splitters = {' '};
        string[] numArr = input.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numArr.Length; i++)
        {
            sum += ulong.Parse(numArr[i]);
        }

        return sum;
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "SumOfIntsFromString";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.WriteLine("Please enter a string of space-separated positive integers:");
        string input = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("The sum of these elements is {0}", SumFromString(input));

        Console.WriteLine();
        Console.ReadKey();
    }
}


