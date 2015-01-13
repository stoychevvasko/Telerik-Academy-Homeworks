using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that generates and prints to the 
//     console 10 random values in the range [100, 200].

class Random100To200
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "Random100To200";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Random randomGen = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGen.Next(100,201));
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}


