using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a method that asks the user for his name and 
//     prints “Hello, <name>” (for example, “Hello, 
//     Peter!”). Write a program to test this method.

class HelloName
{
    static void GreetByName()
    {
        Console.Write("What is your name? ");

        string name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello, {0}!", name);
        Console.WriteLine();
    }
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "HelloName";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        
        GreetByName();

        Console.ReadKey();
    }
}


