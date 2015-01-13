using System;
using System.Threading;
using System.Globalization;

class PrintUserFirstLastName
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "PrintUserFirstLastName.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("Please type your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine();
        
        Console.WriteLine("Please type your surname: ");
        string surname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Your full name is {0} {1}.", firstName, surname);
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Congratulations! You're a rock star \\m/");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

